using UnityEngine;

public class DataManager : MonoBehaviour
{
    public enum GameCharacter
    {
        PistolCowboy,
        ShotgunCowboy,
    }

    public static DataManager instance;

    private void Awake()
    {
        if(instance != null) Destroy(gameObject);
        instance = this;
    }

}