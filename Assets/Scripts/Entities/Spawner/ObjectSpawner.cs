using UnityEngine;
using UnityEngine.SocialPlatforms;

public class ObjectSpawner : MonoBehaviour
{
    private float spawnTimer;

    [SerializeField] private string PoolTag;

    [SerializeField, Range(0.5f, 10f)] private float spawnDelay;
    [SerializeField, Range(0.5f, 3f)] private float spawnDelayMin;
    [SerializeField, Range(4f, 10f)] private float spawnDelayMax;

    [SerializeField, Range(9f, 10f)] private float spawnXValue;
    [SerializeField, Range(0f, 5f)] private float spawnYValue;

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
        GameObject obj = GameManager.Instance.objectPool.SpawningPool(PoolTag);

        obj.transform.position = new Vector2(spawnX, spawnY);
        obj.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    }
}