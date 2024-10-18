using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaDeath : MonoBehaviour
{
    private CharaController controller;
    private Rigidbody2D rb;

    private float dispawnTime = 2f;

    private void Awake()
    {
        controller = GetComponent<CharaController>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnDeath += OnDeath;
    }

    private void OnDeath()
    {
        Invoke("DisactiveChara", dispawnTime);
    }

    private void DisactiveChara()
    {
        gameObject.SetActive(false);
    }
}
