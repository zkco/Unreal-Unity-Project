using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
}
