using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Difficulty
    {
        Normal,
        Hard
    }

    public static GameManager Instance;
    public ObjectPool objectPool;
    public bool isPlaying;

    private void Awake()
    {
        if(Instance != null) Destroy(gameObject);
        Instance = this;

        objectPool = GetComponent<ObjectPool>();
    }

    private void Start()
    {
        isPlaying = true;
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
