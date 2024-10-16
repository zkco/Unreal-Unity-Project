using TMPro;
using UnityEngine;

public class ScoreCalc : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreTMP;
    private int _score;

    private void Start()
    {
        _score = 0;
    }

    private void Update()
    {
        _score += SetScore();
        _scoreTMP.text = _score.ToString();
    }
    
    public int SetScore()
    {
        int myScore = 0;
        //스코어 받아오기

        return myScore;
    }
}