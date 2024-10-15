using System;
using UnityEngine;

public class CharacterLook : MonoBehaviour
{
    private GameController _gameController;
    private SpriteRenderer _playerSprite;

    private void Awake()
    {
        _gameController = GetComponent<GameController>();
        _playerSprite = GetComponentInChildren<SpriteRenderer>(); //캐릭터 스프라이트가 안에 있을 경우를 대비해 InChildren추가함
    }

    private void Start()
    {
        _gameController.OnLookEvent += OnLook;
    }

    private void OnLook(Vector2 position)
    {
        flipCharacter(position);
    }

    public void flipCharacter(Vector2 position)
    {
        float rotZ = Mathf.Atan2(position.y, position.x) * Mathf.Rad2Deg;
        _playerSprite.flipX = Mathf.Abs(rotZ) > 90;
    }
}