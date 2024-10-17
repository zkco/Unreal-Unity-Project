using UnityEngine;

[CreateAssetMenu(fileName = "Object Default Stat", menuName = "Stat/Object/Default", order = 1)]
public class ObjectDefaultStat : ScriptableObject
{
    [Header("Object Default Stat")] //장애물(엄폐물)
    public string ObjectTag;
    public int HP;
    public float delay;
}
