using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // TODO ���ӿ��� ������ ���� 
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.SetActive(false);
        }
        
    }
}
