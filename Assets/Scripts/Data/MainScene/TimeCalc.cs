using TMPro;
using UnityEngine;

public class TimeCalc : MonoBehaviour
{
    [SerializeField] private TMP_Text _timeTMP;
    private int _time;

    private void Start()
    {
        _time = 0;
        Time.timeScale = Time.deltaTime;
    }

    private void Update()
    {
        _time++;
        _timeTMP.text = _time.ToString();
    }

    private void TimeIncrease()
    {
        _time = (int)Time.deltaTime;
    }
}