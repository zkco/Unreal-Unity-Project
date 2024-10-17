using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlip : MonoBehaviour
{
    private CharaController controller;

    private void Awake()
    {
        controller = GetComponent<CharaController>();

    }

    private void Start()
    {
        controller.OnMoveEvent += FlipSprite;
    }

    private void FlipSprite(Vector2 direction)
    {
        if (direction.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180f, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
