using System.Collections;
using TMPro;
using UnityEngine;

public class TotalScoreCalc : MonoBehaviour
{
    [SerializeField] private TMP_Text _tmpTime;
    [SerializeField] private TMP_Text _tmpScore;
    [SerializeField] private TMP_Text _tmpTotalScore;
    [SerializeField] private GameObject RetryPanel;
    private readonly WaitForSeconds WaitFor3Seconds = new WaitForSeconds(3f);
    private readonly WaitForSeconds WaitForFewSeconds = new WaitForSeconds(0.02f);

    //TODO : 점수를 받아와 표시할 변수 추가
    private int _time;
    private int _score;
    private int _totalScore;

    private void Awake()
    {

    }
    private void Start()
    {
        _time = (int)TimeCalc._time;
        _score = ScoreCalc.Score;

        SaveLoad.SaveScore(_time * 3 + _score);

        _tmpTime.text = _time.ToString();
        _tmpScore.text = _score.ToString();
        StartCalculation();

        if(RetryPanel.activeSelf == true)
        {
            RetryPanel.SetActive(false);
        }
    }

    private void Update()
    {
        _tmpTime.text = _time.ToString();
        _tmpScore.text = _score.ToString();
        _tmpTotalScore.text = _totalScore.ToString();
        if (_time == 0 && _score == 0)
        {
            RetryPanel.SetActive(true);
            StopCoroutine(TimeCalcTotalScore());
            StopCoroutine(ScoreCalcTotalScore());
        }
    }

    private IEnumerator TimeCalcTotalScore()
    {
        yield return WaitFor3Seconds;
        if (_time > 0)
        {
            for(; _time > 0; _time--)
            {
                _totalScore += 3;
                yield return WaitForFewSeconds;
            }
        }
    }
    private IEnumerator ScoreCalcTotalScore()
    {
        yield return WaitFor3Seconds;
        if (_score > 0)
        {
            for (; _score > 0; _score--)
            {
                _totalScore++;
                yield return WaitForFewSeconds;
            }
        }
    }

    private void StartCalculation()
    {
        StartCoroutine(TimeCalcTotalScore());
        StartCoroutine(ScoreCalcTotalScore());
    }
}
