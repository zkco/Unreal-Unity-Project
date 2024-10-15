using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public ObjectPool objectPool;

    private void Awake()
    {
        if(Instance != null) Destroy(gameObject);
        Instance = this;

        objectPool = GetComponent<ObjectPool>();
    }
}
