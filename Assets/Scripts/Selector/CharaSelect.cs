using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaSelect : MonoBehaviour
{
    public GameObject[] charactors;

    private void Start()
    {
        SelectManager.instance.SetCharactor(charactors);
    }
}
