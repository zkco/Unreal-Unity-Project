using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SingleBtn : MonoBehaviour
{
    public void CharacterSelectScene()
    {
        SceneManager.LoadScene("CharacterSelectScene"); // ���⿡ ���� �̵��� �� �̸��� �����ϴ�.
    }
}
