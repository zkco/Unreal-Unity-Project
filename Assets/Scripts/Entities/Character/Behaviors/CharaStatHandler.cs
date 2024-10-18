using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaStatHandler : MonoBehaviour
{
    [SerializeField] public CharacterDefaultStat stat;

    public float CurrentHP;

    private void Start()
    {
        CurrentHP = stat.HP;
    }
}
