using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDefaultBehavior : MonoBehaviour
{
    [SerializeField] private ObjectDefaultStat stat;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // TODO : �Ѿ� ���� �� �ǰ� �� ���� �׸� �ۼ�
    }

    private void Hited()
    {
        int damage = 0;
        // TODO : �ǰ� �� BulletTag �Ǵ� Enemy�±׿� ���� �ٸ� ������ �߻�
        stat.HP -= damage;
    }
}
