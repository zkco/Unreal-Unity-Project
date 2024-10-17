using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaAiming : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawnPoint;

    private CharaController controller;

    private void Awake()
    {
        controller = GetComponent<CharaController>();
    }

    private void Start()
    {
        controller.OnAimEvent += Aim;
    }

    private void Aim(Vector2 vector)
    {
        RotateAim(vector);
    }

    private void RotateAim(Vector2 vector)
    {
        float rotZ = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;

        bulletSpawnPoint.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
