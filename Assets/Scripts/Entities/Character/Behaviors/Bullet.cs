using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public float speed = 10;
    public float damage = 1;
    Vector2 direction;

    public Vector2 Direction 
    {
        set 
        {
            direction = value.normalized;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
