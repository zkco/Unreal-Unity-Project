using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class TotalScoreCalc : MonoBehaviour
{
    [SerializeField] private TMP_Text _tmpTime;
    [SerializeField] private TMP_Text _tmpScore;
    [SerializeField] private TMP_Text _tmpTotalScore;
    [SerializeField] private GameObject RetryPanel;
    private readonly WaitForSeconds WaitFor2Seconds = new WaitForSeconds(2f);

    //TODO : ������ �޾ƿ� ǥ���� ���� �߰�
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
        yield return new WaitForSeconds(3f);
        if (_time > 0)
        {
            for(; _time > 0; _time--)
            {
                _totalScore += 3;
                yield return WaitFor2Seconds;
            }
        }
    }
    private IEnumerator ScoreCalcTotalScore()
    {
        yield return new WaitForSeconds(3f);
        if (_score > 0)
        {
            for (; _score > 0; _score--)
            {
                _totalScore++;
                yield return WaitFor2Seconds;
            }
        }
    }

    private void StartCalculation()
    {
        StartCoroutine(TimeCalcTotalScore());
        StartCoroutine(ScoreCalcTotalScore());
    }
}
