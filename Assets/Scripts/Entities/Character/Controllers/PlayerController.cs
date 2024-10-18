using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : CharaController
{
    private Camera _camera;

    [SerializeField]private Transform bulletSpawnPoint;


    protected override void Awake()
    {
        base.Awake();
        _camera = Camera.main;
    }

    private void OnMove(InputValue inputValue)
    {
        Vector2 moveDirection;
        if (isDead) moveDirection = Vector2.zero;
        else moveDirection = inputValue.Get<Vector2>().normalized;

        CallOnMoveEvent(moveDirection);
    }

    private void OnAim(InputValue inputValue)
    {
        if (isDead) return;
        Vector2 mousePos = inputValue.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(mousePos);
        Vector2 lookDirection = (worldPos - (Vector2)bulletSpawnPoint.position).normalized;

        CallOnAimEvent(lookDirection);
    }

    private void OnFire(InputValue inputValue)
    {
        if (isDead) return;
        IsFiring = inputValue.isPressed;
    }
}
