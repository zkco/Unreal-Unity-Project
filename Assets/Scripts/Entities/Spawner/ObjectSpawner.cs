using UnityEngine;
using UnityEngine.SocialPlatforms;

public class ObjectSpawner : MonoBehaviour
{
    public enum SpawnType
    {
        DefaultSpawner,
        RandomDelaySpawner,
        RandomPositionSpawner,
        AllRandomSpawner
    }
    private float spawnTimer;

    [Header("Required")]
    [SerializeField] private string PoolTag;
    [SerializeField] private SpawnType spawnType;

    [Header("Fixed Delay For Default or RandomPosition")]
    [SerializeField] private float spawnDelay = 0;
    [Header("Random Delay For RandomDelay or AllRandom")]
    [SerializeField] private float spawnDelayMin = 0;
    [SerializeField] private float spawnDelayMax = 0;
    [Header("Fixed Position For Default or RandomDelay")]
    [SerializeField] private float spawnXValue = 0;
    [SerializeField] private float spawnYValue = 0;
    [Header("Random X position For RandomPosition or AllRandom")]
    [SerializeField] private float spawnXValueMin = 0;
    [SerializeField] private float spawnXValueMax = 0;
    [Header("Random Y position For RandomPosition or All Random")]
    [SerializeField] private float spawnYValueMin = 0;
    [SerializeField] private float spawnYValueMax = 0;
    // X나 Y축을 고정하고 싶다면 RandomPosition이나 AllRandom에서 고정할 축 min,max 값을 맞춰줄 것

    private string selector;

    private void Start()
    {
        selector = spawnType.ToString();
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
            switch (selector)
            {
                case "DefaultSpawner":
                case "RandomPositionSpawner":
                    break;
                case "RandomDelaySpawner":
                case "AllRandomSpawner":
                    spawnDelay = Random.Range(spawnDelayMin, spawnDelayMax);
                    break;
            }
        }
    }

    private void CreateObject()
    {
        float spawnX = 0, spawnY = 0;
        switch (selector)
        {
            case "DefaultSpawner":
            case "RandomDelaySpawner":
                spawnX = spawnXValue;
                spawnY = spawnYValue;
                break;
            case "RandomPositionSpawner":
            case "AllRandomSpawner":
                spawnX = Random.Range(spawnXValueMin, spawnXValueMax);
                spawnY = Random.Range(spawnYValueMin, spawnYValueMax);
                break;
        }
        GameObject obj = GameManager.Instance.objectPool.SpawningPool(PoolTag);
        obj.transform.position = new Vector2(spawnX, spawnY);
        obj.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    }
}