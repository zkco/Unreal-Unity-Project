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
            DontDestroyOnLoad(gameObject); // 씬 전환 시에도 오브젝트 유지
        }
        else
        {
            Destroy(gameObject); // 이미 인스턴스가 존재할 경우 제거
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
