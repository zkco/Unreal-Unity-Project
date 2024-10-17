using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class EnamyCharaController : CharaController
{
    [SerializeField] private CharaHealthController PlayerHP;

    Vector2 direction;

    private void OnEnable()
    {
        direction = Vector2.left;
    }

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        ShootGun();
        CallOnMoveEvent(direction);
    }

    private void ShootGun()
    {
        IsFiring = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            // TODO 체력 감소 넣을 예정
            direction = Vector2.zero;
            //gameObject.SetActive(false);
        }
    }
}
