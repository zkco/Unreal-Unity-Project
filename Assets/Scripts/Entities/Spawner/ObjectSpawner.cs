using UnityEngine;
using UnityEngine.SocialPlatforms;

public class ObjectSpawner : MonoBehaviour
{
    private ObjectPool objectPool;

    private float spawnTimer;

    [SerializeField] private string PoolTag;

    [SerializeField, Range(1f, 10f)] private float spawnDelay;
    [SerializeField, Range(1f, 3f)] private float spawnDelayMin;
    [SerializeField, Range(4f, 10f)] private float spawnDelayMax;

    [SerializeField, Range(9f, 10f)] private float spawnXValue;
    [SerializeField, Range(0f, 5f)] private float spawnYValue;

    private void Awake()
    {
        objectPool = GetComponent<ObjectPool>();
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
            CreateObject();
            spawnTimer = 0f;
            spawnDelay = Random.Range(spawnDelayMin, spawnDelayMax);
        }
    }

    private void CreateObject()
    {
        float spawnX = spawnXValue;
        float spawnY = Random.Range(-spawnYValue, spawnYValue);
        GameObject obj = objectPool.SpawningPool(PoolTag);

        obj.transform.position = new Vector2(spawnX, spawnY);
    }
}