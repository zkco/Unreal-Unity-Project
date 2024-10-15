using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : GameController
{
    private Camera _mainCamera;

    protected override void Awake()
    {
        base.Awake();
        _mainCamera = Camera.main;
    }

    public void OnLook(InputValue value)
    {
        Vector2 mousePos = value.Get<Vector2>();
        Vector2 worldPos = _mainCamera.WorldToScreenPoint(mousePos);
        mousePos = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(mousePos);
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnFire(InputValue value)
    {
        _nowAttacking = value.isPressed;
    }

    public void OnAim(InputValue value)
    {
        _nowAiming = value.isPressed;
    }
}
