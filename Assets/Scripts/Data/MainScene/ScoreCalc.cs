using TMPro;
using UnityEngine;

public class ScoreCalc : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreTMP;
    public static int Score;

    private void Start()
    {
        Score = 0;
    }

    private void Update()
    {
        _scoreTMP.text = $"Score : {Score}";
    }
}