using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlip : MonoBehaviour
{
    private CharaController controller;

    private SpriteRenderer charaRenderer;
    private BoxCollider2D charaCollider;

    private void Awake()
    {
        controller = GetComponent<CharaController>();

        charaRenderer = GetComponentInChildren<SpriteRenderer>();
        charaCollider = GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += FlipSprite;
    }

    private void FlipSprite(Vector2 direction)
    {
        if(direction.x <0)
        {
            charaRenderer.flipX = true;
            charaCollider.offset = new Vector2 (-charaCollider.offset.x,charaCollider.offset.y);
        }
    }
}
