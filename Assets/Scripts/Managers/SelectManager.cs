using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public static SelectManager instance;

    public static int charactorID;
    public GameObject[] charactors;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetID(int id)
    {
        charactorID = id;
    }

    public void SetCharactor(GameObject[] charactor)
    {
        charactors = charactor;
        charactors[charactorID].SetActive(true);
    }
}
