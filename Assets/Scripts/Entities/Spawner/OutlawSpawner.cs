using UnityEngine;

public class OutlawSpawner : MonoBehaviour
{
    private ObjectPool outlawPool;

    private float spawnDelay;
    private float spawnDelayMin;
    private float spawnDelayMax;

    private float spawnTimer;

    private float spawnXValue;
    private float spawnYValue;

    private void Awake()
    {
        outlawPool = GetComponent<ObjectPool>();
    }

    private void Start()
    {
        spawnDelay = 3f;
        spawnDelayMin = 2f;
        spawnDelayMax = 5f;

        spawnTimer = 0f;

        spawnXValue = 10f;
        spawnYValue = 4.5f;
    }

    private void Update()
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
            spawnDelay = Random.Range(spawnDelayMin, spawnDelayMax);
        }
    }

    private void CreateOutlaw()
    {
        float spawnX = spawnXValue;
        float spawnY = Random.Range(-spawnYValue, spawnYValue);
        GameObject obj = outlawPool.SpawningPool("Outlaw");

        obj.transform.position = new Vector2(spawnX, spawnY);
    }
}