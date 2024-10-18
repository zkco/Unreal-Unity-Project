using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public enum Difficulty
    {
        Normal,
        Hard
    }

    public static DifficultyManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // �� ��ȯ �ÿ��� ������Ʈ ����
        }
        else
        {
            Destroy(gameObject); // �̹� �ν��Ͻ��� ������ ��� ����
        }
    }

    public static void SaveDifficulty(Difficulty difficulty)
    {
        PlayerPrefs.SetInt("GameDifficulty", (int)difficulty);
        PlayerPrefs.Save();
    }

    public static Difficulty GetSavedDifficulty()
    {
        return (Difficulty)PlayerPrefs.GetInt("GameDifficulty", (int)Difficulty.Normal);
    }
}
