using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : CharaController
{
    private Camera _camera;

    [SerializeField]private Transform bulletSpawnPoint;

    private Vector2 worldPos;


    protected override void Awake()
    {
        base.Awake();
        _camera = Camera.main;
    }

    protected override void Update()
    {
        base.Update();

        CallOnAimEvent(worldPos);
    }

    private void OnMove(InputValue inputValue)
    {
        Vector2 moveDirection = inputValue.Get<Vector2>().normalized;
        
        CallOnMoveEvent(moveDirection);
    }

    private void OnAim(InputValue inputValue)
    {
        Vector2 mousePos = inputValue.Get<Vector2>();
        worldPos = _camera.ScreenToWorldPoint(mousePos);
        //Vector2 lookDirection = (worldPos - (Vector2)bulletSpawnPoint.position).normalized;

        //CallOnAimEvent(worldPos);
    }

    private void OnFire(InputValue inputValue)
    {
        IsFiring = inputValue.isPressed;
    }
}
