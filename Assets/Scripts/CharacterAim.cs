using UnityEngine;

public class CharacterAim : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _weaponSprite;
    [SerializeField] private Transform _weaponRotatePivot;
    [SerializeField] private SpriteRenderer _characterRenderer;
    
    private GameController _gameController;

    private void Awake()
    {
        _gameController = GetComponent<GameController>();
    }

    private void Start()
    {
        _gameController.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateWeapon(direction);
    }

    private void RotateWeapon(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        _weaponSprite.flipX = Mathf.Abs(rotZ) > 90;
        _weaponRotatePivot.rotation = Quaternion.Euler(0f, 0f, rotZ);
    }
}