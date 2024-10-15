using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnamyCharaController : CharaController
{
    private void FixedUpdate()
    {
        Vector2 direction = Vector2.left;
        
        CallOnMoveEvent(direction);
    }
}
