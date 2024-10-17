using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class EnamyCharaController : CharaController
{
    Vector2 direction = Vector2.left;

    private void FixedUpdate()
    {
        

        ShootGun();
        CallOnMoveEvent(direction);
    }

    private void ShootGun()
    {
        CallOnMoveEvent(Vector2.zero);
        IsFiring = true;
    }
}
