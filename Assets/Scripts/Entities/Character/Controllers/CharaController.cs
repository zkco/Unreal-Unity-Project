using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnAimEvent;
    public event Action OnFireEvent;

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
