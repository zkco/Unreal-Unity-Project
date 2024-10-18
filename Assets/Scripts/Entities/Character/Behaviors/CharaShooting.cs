using System;
using UnityEngine;

public class CharaShooting : MonoBehaviour
{
    private CharaController controller;

    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private string bulletTag;
    private Vector2 aimeDirection = Vector2.right;

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
        SoundManager.Instance.PlaySef("GunShot");
        GameObject obj = GameManager.Instance.objectPool.SpawningPool(bulletTag);

        obj.transform.position = bulletSpawnPoint.position;
        obj.transform.rotation = bulletSpawnPoint.rotation;
        //obj.GetComponent<Bullet>().Direction = Vector2.right;
    }
}