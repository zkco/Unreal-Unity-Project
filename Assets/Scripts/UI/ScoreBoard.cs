using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> scoreDisplayTexts = new List<TextMeshProUGUI>();
    private List<int> scores;

    #region Animation
    private int count;
    private int[] currentScores;
    private int[] targetScores;
    private float animationElapsedTime = 0f;
    private float animationDuration = 2f;
    #endregion

    private void Awake()
    {
        scores = new List<int> { 1000, 2000, 3000, 996000, 900, 500 };
    }

    private void Start()
    {
        scores.Sort((a, b) => b.CompareTo(a));
        count = Mathf.Min(scoreDisplayTexts.Count, scores.Count);
        currentScores = new int[count];
        targetScores = new int[count];

        for (int i = 0; i < count; i++)
            targetScores[i] = scores[i];
    }

    private void Update()
    {
        AnimateScoreDisplay();
    }

    private void AnimateScoreDisplay ()
    {
        if (animationElapsedTime >= animationDuration)
            return;
        animationElapsedTime = Mathf.Min(animationElapsedTime + Time.deltaTime, animationDuration);

        for (int i = 0; i < count; i++)
        {
            currentScores[i] = (int)(targetScores[i] * (animationElapsedTime / animationDuration));
            scoreDisplayTexts[i].text = currentScores[i].ToString();
        }
    }
}
