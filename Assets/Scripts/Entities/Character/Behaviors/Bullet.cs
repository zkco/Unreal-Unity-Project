using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 10;
    public float damage = 1;
    Vector2 direction;

    public Vector2 Direction
    {
        get
        {
            return direction;
        }
        set
        {
            direction = value.normalized;
        }
    }

    void Start()
    {
        direction = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}