using UnityEngine;

public class OutlawSpawner : MonoBehaviour
{
    private ObjectPool outlawPool;

    private float spawnX;
    private float spawnY;

    private float spawnDelay;
    private float spawnDelayMin;
    private float spawnDelayMax;

    private float spawnTimer;

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
        float spawnX = transform.position.x;
        float spawnY = Random.Range(-spawnYValue, spawnYValue);
        GameObject obj = outlawPool.SpawningPool("Outlaw");

        obj.transform.position = new Vector2(spawnX, spawnY);
    }
}