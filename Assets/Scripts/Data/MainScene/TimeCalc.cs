using TMPro;
using UnityEngine;

public class TimeCalc : MonoBehaviour
{
    [SerializeField] private TMP_Text _timeTMP;
    public float _time;

    private void Start()
    {
        _time = 0;
    }

    private void Update()
    {
        _time += Time.deltaTime;
        _timeTMP.text = ((int)_time).ToString();
    }
}