using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaDeath : MonoBehaviour
{
    private CharaHealthController healthController;
    private Rigidbody2D rb;

    private void Awake()
    {
        healthController = GetComponent<CharaHealthController>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        healthController.OnDeath += OnDeath;
    }

    private void OnDeath()
    {
        rb.velocity = Vector3.zero;
    }
}
