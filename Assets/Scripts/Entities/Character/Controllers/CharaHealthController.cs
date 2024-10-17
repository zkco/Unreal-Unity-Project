using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaHealthController : MonoBehaviour
{
    private CharaStatHandler stats;
    // private float timeSinceLasstChange = float.MaxValue;
    // private bool isAttacked = false;

    public event Action OnDeath;
    public event Action OnDamage;

    public float CurrentHP {  get; private set; }

    public float MaxHP => stats.stat.MaxHP;

    private void Awake()
    {
        stats = GetComponent<CharaStatHandler>();
    }

    private void Start()
    {
        CurrentHP = stats.stat.HP;
    }

    public bool ChangeHealth(float change)
    {
        CurrentHP += change;
        CurrentHP = Mathf.Clamp(CurrentHP, 0, MaxHP);

        if(CurrentHP<=0f)
        {
            CallDeath();
            return true;
        }

        if(change>=0)
        {

        }
        else
        {
            OnDamage?.Invoke();
        }

        return true;
    }

    private void CallDeath()
    {
        OnDeath?.Invoke();
    }
}
