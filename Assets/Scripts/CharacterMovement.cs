using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private GameController _gameController;
    private Rigidbody2D _characterRB;

    private Vector2 _moveDirection = Vector2.zero;

    private void Awake()
    {
        _gameController = GetComponent<GameController>();
        _characterRB = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _gameController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        MoveToDirection(_moveDirection);
    }

    private void Move(Vector2 direction)
    {
        _moveDirection = direction;
    }

    private void MoveToDirection(Vector2 direction) 
    {
        direction = direction * 5; //TODO : Ä³¸¯ÅÍ speed ½ºÅÈÀ» °¡Á®¿Í °öÇØÁÜ
        _characterRB.velocity = direction;
    }
}