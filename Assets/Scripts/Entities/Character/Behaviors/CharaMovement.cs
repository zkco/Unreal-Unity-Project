using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMovement : MonoBehaviour
{
    private Rigidbody2D charaRigidbody;
    private CharaController controller;
    private CharaStatHandler stats;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        charaRigidbody = GetComponent<Rigidbody2D>();
        controller = GetComponent<CharaController>();
        stats = GetComponent<CharaStatHandler>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        // 캐릭터 스피드 적용할 예정
        direction = direction * stats.stat.Speed;

        charaRigidbody.velocity = direction;
    }
}
