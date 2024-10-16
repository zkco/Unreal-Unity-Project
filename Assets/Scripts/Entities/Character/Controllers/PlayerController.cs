using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : CharaController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void OnMove(InputValue inputValue)
    {
        Vector2 moveDirection = inputValue.Get<Vector2>().normalized;
        
        CallOnMoveEvent(moveDirection);
    }

    private void OnAim(InputValue inputValue)
    {
        Vector2 mousePos = inputValue.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(mousePos);
        Vector2 lookDirection = (worldPos - (Vector2)transform.position).normalized;

        CallOnAimEvent(lookDirection);
    }

    private void OnFire(InputValue inputValue)
    {
        IsFiring = inputValue.isPressed;
    }
}
