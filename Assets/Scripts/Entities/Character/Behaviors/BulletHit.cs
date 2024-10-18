using UnityEngine;

public class BulletHit : MonoBehaviour
{
    [SerializeField] private string targetLayerName;

    private Bullet bullet;

    private void Awake()
    {
        bullet = GetComponent<Bullet>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hited(collision);
    }

    private void Hited(Collider2D collision)
    {
        CharaStatHandler collisionStat = collision.GetComponent<CharaStatHandler>();
        CharaController collisionControl = collision.GetComponent<CharaController>();

        if (collision.gameObject.layer == LayerMask.NameToLayer(targetLayerName))
        {
            switch (collision.gameObject.tag)
            {
                case "Enemy":
                    Debug.Log("Enemy Hit");
                    collisionStat.CurrentHP -= bullet.damage;
                    RemoveBullet();
                    break;

                case "Player":
                    Debug.Log("Player Hit");
                    collisionStat.CurrentHP -= bullet.damage;
                    RemoveBullet();
                    break;
            }
        }
        else if (collision.gameObject.tag == "BulletRemover")
        {
            RemoveBullet();
        }

        if (collisionStat?.CurrentHP <= 0)
        {
            collisionControl.CallOnDeathEvent();
        }
    }

    private void RemoveBullet()
    {
        gameObject.SetActive(false);
    }
}