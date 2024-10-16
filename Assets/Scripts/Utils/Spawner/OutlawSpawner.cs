using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlawSpawner : MonoBehaviour
{
    private ObjectPool outlawPool;

    private float spawnX;
    private float spawnY;
    private float spawnDelay = 5f;
    private float spawnTimer = 0f;



    private void Awake()
    {
        outlawPool = GetComponent<ObjectPool>();
    }

    private void FixedUpdate()
    {
        SpawnTimeCheck();
    }

    private void SpawnTimeCheck()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnDelay)
        {
            CreateOutlaw();
            spawnTimer = 0f;
        }
    }

    private void CreateOutlaw()
    {
        float spawnX = (transform.position.x + 0.5f);
        float spawnY = Random.Range(-4f, 4f);
        GameObject obj = outlawPool.SpawningPool("Outlaw");

        obj.transform.position = new Vector2(spawnX, spawnY);
    }
}
