using UnityEngine;

[CreateAssetMenu(fileName = "CharacterStatSO", menuName = "CharacterStatSO/Default", order = 0)]
public class CharaStatSO : ScriptableObject
{
    [Header("Character Info")]
    public float CharaSpeed;
    public LayerMask target;
}
