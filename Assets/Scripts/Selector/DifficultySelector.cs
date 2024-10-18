using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    public void SelectNormalDifficulty()
    {
        GameManager.SaveDifficulty(GameManager.Difficulty.Normal);
        Debug.Log("Normal Difficulty Selected");
        // 필요한 경우 게임 씬을 로드하거나 다른 작업을 수행합니다.
    }

    public void SelectHardDifficulty()
    {
        GameManager.SaveDifficulty(GameManager.Difficulty.Hard);
        Debug.Log("Hard Difficulty Selected");
        // 필요한 경우 게임 씬을 로드하거나 다른 작업을 수행합니다.
    }
}
