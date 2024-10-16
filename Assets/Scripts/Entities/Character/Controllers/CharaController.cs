using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnAimEvent;
    public event Action OnFireEvent;

    private float timeSinceLastAttack = float.MaxValue;
    protected bool IsFiring { get; set; }

    protected virtual void Update()
    {
        HandleAttackDelay();
    }

    private void HandleAttackDelay()
    {
        if (timeSinceLastAttack <= 0.3f)
        {
            timeSinceLastAttack += Time.deltaTime;
        }

        if (IsFiring && timeSinceLastAttack > 0.3f)
        {
            timeSinceLastAttack = 0;
            CallOnFireEvent();
        }
    }


    protected void CallOnMoveEvent(Vector2 vector2)
    {
        OnMoveEvent?.Invoke(vector2);
    }

    protected void CallOnAimEvent(Vector2 vector2)
    {
        OnAimEvent?.Invoke(vector2);
    }

    protected void CallOnFireEvent()
    {
        OnFireEvent?.Invoke();
    }
}
