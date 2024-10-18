using UnityEngine;
using System.Collections;
public class OutlawSpawner : MonoBehaviour
{
    private ObjectPool outlawPool;

    private float spawnDelay; // 스폰 간격

    [Header("Spawn Settings")]
    public int normalSpawnAmount = 3; // 노말 난이도에서 생성할 적의 수
    public int hardSpawnAmount = 5; // 하드 난이도에서 생성할 적의 수

    private void Awake()
    {
        outlawPool = GetComponent<ObjectPool>();
    }

    private void Start()
    {
        spawnDelay = 1f; // 스폰 간격 설정 (1초)
        StartCoroutine(SpawnOutlaws());
    }

    private IEnumerator SpawnOutlaws()
    {
        // 현재 난이도 가져오기
        DifficultyManager.Difficulty difficulty = DifficultyManager.GetSavedDifficulty();
        int spawnAmount = (difficulty == DifficultyManager.Difficulty.Hard) ? hardSpawnAmount : normalSpawnAmount;

        for (int i = 0; i < spawnAmount; i++)
        {
            CreateOutlaw(); // 적 스폰
            yield return new WaitForSeconds(spawnDelay); // 스폰 간격만큼 대기
        }
    }

    private void CreateOutlaw()
    {
        float spawnY = Random.Range(-4.5f, 4.5f); // Y 위치 랜덤 설정
        GameObject obj = outlawPool.SpawningPool("Outlaw");
        obj.transform.position = new Vector2(10f, spawnY); // 적 스폰 위치
        Debug.Log($"적 생성됨: {obj.name}");
    }
}