using UnityEngine;
using System.Collections;
public class OutlawSpawner : MonoBehaviour
{
    private ObjectPool outlawPool;

    private float spawnDelay; // ���� ����

    [Header("Spawn Settings")]
    public int normalSpawnAmount = 3; // �븻 ���̵����� ������ ���� ��
    public int hardSpawnAmount = 5; // �ϵ� ���̵����� ������ ���� ��

    private void Awake()
    {
        outlawPool = GetComponent<ObjectPool>();
    }

    private void Start()
    {
        spawnDelay = 1f; // ���� ���� ���� (1��)
        StartCoroutine(SpawnOutlaws());
    }

    private IEnumerator SpawnOutlaws()
    {
        // ���� ���̵� ��������
        DifficultyManager.Difficulty difficulty = DifficultyManager.GetSavedDifficulty();
        int spawnAmount = (difficulty == DifficultyManager.Difficulty.Hard) ? hardSpawnAmount : normalSpawnAmount;

        for (int i = 0; i < spawnAmount; i++)
        {
            CreateOutlaw(); // �� ����
            yield return new WaitForSeconds(spawnDelay); // ���� ���ݸ�ŭ ���
        }
    }

    private void CreateOutlaw()
    {
        float spawnY = Random.Range(-4.5f, 4.5f); // Y ��ġ ���� ����
        GameObject obj = outlawPool.SpawningPool("Outlaw");
        obj.transform.position = new Vector2(10f, spawnY); // �� ���� ��ġ
        Debug.Log($"�� ������: {obj.name}");
    }
}