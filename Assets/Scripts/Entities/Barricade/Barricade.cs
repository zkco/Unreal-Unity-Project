using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // TODO 게임오버 적용할 예정 
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.SetActive(false);
        }
        
    }
}
