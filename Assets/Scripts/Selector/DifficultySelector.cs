using UnityEngine;
using UnityEngine.UI;

public class DifficultySelector : MonoBehaviour
{    
    public enum Difficulty
    {
        Normal,
        Hard
    }
    public void SelectNormalDifficulty()
    {
        PlayerPrefs.SetInt("GameDifficulty", (int)Difficulty.Normal);
        Debug.Log("Normal Difficulty Selected");
        // 게임 씬을 로드하거나 다른 작업을 추가할 수 있습니다.
    }

    // 이 함수는 Hard 난이도를 선택했을 때 호출됩니다.
    public void SelectHardDifficulty()
    {
        PlayerPrefs.SetInt("GameDifficulty", (int)Difficulty.Hard);
        Debug.Log("Hard Difficulty Selected");
        // 게임 씬을 로드하거나 다른 작업을 추가할 수 있습니다.
    }
}
