using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character Default Stat", menuName = "Stat/Character/Default", order = 0)]

public class CharacterDefaultStat : ScriptableObject
{
    [Header("Default Stat")]
    public int HP;
    public int MaxHP;
    public float Speed;
}
