using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject Player;
    public ObjectPool ObjectPool;
    public List<GameObject> CharacterList;
    public string CharacterTag;

    private void Awake()
    {
        if(Instance != null) Destroy(gameObject);
        Instance = this;

        ObjectPool = GetComponent<ObjectPool>();
    }
}
