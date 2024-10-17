using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        Vector2 direction = (vector - (Vector2)bulletSpawnPoint.position);
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (Mathf.Abs(rotZ) <= 90)
        {
            bulletSpawnPoint.rotation = Quaternion.Euler(0, 0, rotZ);
        }
    }
}
