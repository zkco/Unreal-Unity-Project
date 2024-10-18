using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Xml.Serialization;
using UnityEngine;

public class EnamyCharaController : CharaController
{
    private CharaStatHandler stat;

    Vector2 direction;

    protected override void Awake()
    {
        base.Awake();
        stat = GetComponent<CharaStatHandler>();
    }

    private void OnEnable()
    {
        CallOnReviveEvent();
    }

    private void FixedUpdate()
    {
        ShootGun();
        EnemyMove();
    }

    private void ShootGun()
    {
        if(!isDead)
        {
            IsFiring = true;
        }
        else
        {
            IsFiring = false;
        }
    }

    private void EnemyMove()
    {
        if(isDead)
        {
            direction = Vector2.zero;
        }
        else
        {
            direction = Vector2.left;
        }

        CallOnMoveEvent(direction);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            gameObject.SetActive(false);
        }
    }
}
