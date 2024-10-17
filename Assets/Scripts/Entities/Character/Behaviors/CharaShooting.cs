﻿using System;
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
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.z = 0;
        worldPosition -= (transform.position + new Vector3(0, -0.5f));

        GameObject newBullet = Instantiate<GameObject>(Prefab);
        newBullet.transform.position = transform.position + new Vector3(0,-0.5f);
        newBullet.GetComponent<Bullet>().Direction = worldPosition;
    }
}