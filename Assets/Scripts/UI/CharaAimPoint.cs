using UnityEngine;

public class CharaAimPoint : MonoBehaviour
{
    private CharaController controller;
    [SerializeField] private Transform aimPoint;
    [SerializeField] private Transform bulletSpawnPoint;

    private Camera _camera;

    private float pointX;
    private float pointY;

    private void Awake()
    {
        controller = GetComponent<CharaController>();
        _camera = Camera.main;
    }

    private void Start()
    {
        controller.OnAimEvent += SetAimPoint;
    }

    private void SetAimPoint(Vector2 vector)
    {
        Vector2 bottomLeft = _camera.ViewportToWorldPoint(new Vector3(0, 0, _camera.nearClipPlane));
        Vector2 topRight = _camera.ViewportToWorldPoint(new Vector3(1, 1, _camera.nearClipPlane));

        pointX = Mathf.Clamp(vector.x, bulletSpawnPoint.position.x, topRight.x);
        pointY = Mathf.Clamp(vector.y, bottomLeft.y, topRight.y);

        aimPoint.position = new Vector2(pointX, pointY);
    }
}
