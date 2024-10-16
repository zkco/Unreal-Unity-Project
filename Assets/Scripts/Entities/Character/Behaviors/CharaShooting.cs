using System;
using UnityEngine;

public class CharaShooting : MonoBehaviour
{
    private CharaController controller;

    [SerializeField] private Transform bulletSpawnPoint;
    private Vector2 aimeDirection = Vector2.right;

    public GameObject Prefab;

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
        Instantiate(Prefab, bulletSpawnPoint.position, Quaternion.identity);
    }
}