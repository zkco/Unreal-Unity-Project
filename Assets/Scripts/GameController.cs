using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnFireEvent;
    public event Action OnAimEvent;

    protected bool _nowAttacking = false;
    protected bool _nowAiming = false;

    protected virtual void Awake()
    {

    }

    private void Update()
    {
        
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent.Invoke(direction);
    }

    public void CallFireEvent()
    {
        OnFireEvent.Invoke();
    }

    public void CallAimEvent()
    {
        OnAimEvent.Invoke();
    }

}
