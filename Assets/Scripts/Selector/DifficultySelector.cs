using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    public void SelectNormalDifficulty()
    {
        GameManager.SaveDifficulty(GameManager.Difficulty.Normal);
        Debug.Log("Normal Difficulty Selected");
        // �ʿ��� ��� ���� ���� �ε��ϰų� �ٸ� �۾��� �����մϴ�.
    }

    public void SelectHardDifficulty()
    {
        GameManager.SaveDifficulty(GameManager.Difficulty.Hard);
        Debug.Log("Hard Difficulty Selected");
        // �ʿ��� ��� ���� ���� �ε��ϰų� �ٸ� �۾��� �����մϴ�.
    }
}
