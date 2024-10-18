using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> scoreDisplayTexts = new List<TextMeshProUGUI>();
    [SerializeField] private string emptyRankText = "empty";
    private List<int> scores;

    #region Animation
    private int count;
    private int[] currentScores;
    private int[] targetScores;
    private float animationElapsedTime = 0f;
    [SerializeField] private float animationDuration = 1f;
    #endregion

    private void Awake() {
        scores = SaveLoad.LoadScores();
        
        foreach (var tmp in scoreDisplayTexts) {
            tmp.text = emptyRankText;
        }
    }

    private void Start() {
        InitScoreAnimation();
    }

    private void Update() {
        AnimateScoreDisplay();
    }

    private void InitScoreAnimation() {
        count = Mathf.Min(scoreDisplayTexts.Count, scores.Count);
        currentScores = new int[count];
        targetScores = new int[count];
        for (int i = 0; i < count; i++)
            targetScores[i] = scores[i];
    }

    private void AnimateScoreDisplay () {
        if (animationElapsedTime >= animationDuration) {
            return;
        }
        animationElapsedTime = Mathf.Min(animationElapsedTime + Time.deltaTime, animationDuration);

        for (int i = 0; i < count; i++) {
            currentScores[i] = (int)(targetScores[i] * (animationElapsedTime / animationDuration));
            scoreDisplayTexts[i].text = currentScores[i].ToString();
        }
    }
}
