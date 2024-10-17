using UnityEngine;

[CreateAssetMenu(fileName = "Bullet Default Stat", menuName = "Stat/Bullet/Default", order = 0)]
public class BulletDefaultStat : ScriptableObject
{
    [Header("Default Stat")]
    public string BulletTag;
    public float Speed;
    public float Delay;
    public int Damage;
    public float Size;
    public float Spread;
    public int NumberOfProjectiles;
    public float dir;
}