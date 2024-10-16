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


    private ScoreCalc _mainSceneScore;
    private TimeCalc _mainSceneTime;

    //TODO : ������ �޾ƿ� ǥ���� ���� �߰�
    private int _time;
    private int _score;
    private int _totalScore;


    private void Start()
    {
        _time = (int)_mainSceneTime._time;
        _score = _mainSceneScore.Score;

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
    }

    private IEnumerator TimeCalcTotalScore()
    {
        yield return new WaitForSeconds(3f);
        if (_time > 0)
        {
            for(; _time > 0; _time--)
            {
                _totalScore += 3;
                yield return new WaitForSeconds(0.02f);
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
                yield return new WaitForSeconds(0.02f);
            }
        }
    }

    private void StartCalculation()
    {
        StartCoroutine(TimeCalcTotalScore());
        StartCoroutine(ScoreCalcTotalScore());
        if (_time == 0 && _score == 0)
        {
            StopCoroutine(TimeCalcTotalScore());
            StopCoroutine(ScoreCalcTotalScore());
            RetryPanel.SetActive(true);
        }
    }
}
