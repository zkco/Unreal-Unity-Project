using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlip : MonoBehaviour
{
    private CharaController controller;

    private float one = 1f;

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
            transform.localScale = new Vector3(-one, one, one);
        }
        else
        {
            transform.localScale = new Vector3(one, one, one);
        }
    }
}
