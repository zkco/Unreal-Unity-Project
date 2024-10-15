using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnFireEvent;
    public event Action OnAimEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent.Invoke(direction);
    }

    public void CallFireEvenet()
    {
        OnFireEvent.Invoke();
    }

    public void CallAimEvent()
    {
        OnAimEvent.Invoke();
    }
}
