using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    public void SelectNormalDifficulty()
    {
        DifficultyManager.SaveDifficulty(DifficultyManager.Difficulty.Normal);
        Debug.Log("Normal Difficulty Selected");
        // �ʿ��� ��� ���� ���� �ε��ϰų� �ٸ� �۾��� �����մϴ�.
    }

    public void SelectHardDifficulty()
    {
        DifficultyManager.SaveDifficulty(DifficultyManager.Difficulty.Hard);
        Debug.Log("Hard Difficulty Selected");
        // �ʿ��� ��� ���� ���� �ε��ϰų� �ٸ� �۾��� �����մϴ�.
    }
}
