using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectDefaultBehavior : MonoBehaviour
{
    [SerializeField] private ObjectDefaultStat baseStat;
    public ObjectDefaultStat currentStat { get; private set; }
    private int inputDamage;
    private void Start()
    {
        StatUpdate();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hited(collision);
    }
    private void Hited(Collider2D collision)
    {

        switch (collision.gameObject.tag)
        {
            case "Bullet":
                collision.gameObject.SetActive(false);
                collision.gameObject.TryGetComponent<Bullet>(out Bullet bulletStat);
                inputDamage = (int)bulletStat.damage;
                currentStat.HP -= inputDamage;
                break;
            case "Enemy":
                gameObject.SetActive(false);
                break;
        }
        if (currentStat.HP <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    private void StatUpdate()
    {
        if (baseStat != null)
        {
            currentStat = Instantiate(baseStat);
        }
    }
}
