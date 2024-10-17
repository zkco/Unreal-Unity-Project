using System;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
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
        
        GameObject newBullet = Instantiate<GameObject>(Prefab);
        newBullet.transform.position = transform.position + new Vector3(0,-0.5f);
        newBullet.GetComponent<Bullet>().Direction = new Vector2(-1, 0);
    }
}