using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDefaultBehavior : MonoBehaviour
{
    [SerializeField] private ObjectDefaultStat stat;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // TODO : 총알 구현 후 피격 시 실행 항목 작성
    }

    private void Hited()
    {
        int damage = 0;
        // TODO : 피격 시 BulletTag 또는 Enemy태그에 따라 다른 데미지 발생
        stat.HP -= damage;
    }
}
