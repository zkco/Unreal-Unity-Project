using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public ObjectPool BulletPool;
    public ObjectPool EnemyPool;

    private void Awake()
    {
        if(Instance != null) Destroy(gameObject);
        Instance = this;

        BulletPool = new ObjectPool();
        EnemyPool = new ObjectPool();
    }
}
