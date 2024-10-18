using System;
using UnityEngine;

public class CharaShooting : MonoBehaviour
{
    private CharaController controller;

    [SerializeField] private Transform bulletSpawnPoint;
    private Vector2 aimeDirection = Vector2.right;

    // public GameObject Prefab;

    private void Awake()
    {
        controller = GetComponent<CharaController>();
    }

    private void Start()
    {
        controller.OnFireEvent += OnShoot;
    }

    private void OnShoot()
    {
        CreateBullet();
    }

    private void CreateBullet()
    {
        GameObject obj = GameManager.Instance.objectPool.SpawningPool("Bullet");

        obj.transform.position = bulletSpawnPoint.position;
        obj.transform.rotation = bulletSpawnPoint.rotation;
        //obj.GetComponent<Bullet>().Direction = Vector2.right;
    }
}