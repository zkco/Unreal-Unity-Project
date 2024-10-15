using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SingleBtn : MonoBehaviour
{
    public void CharacterSelectScene()
    {
        SceneManager.LoadScene("CharacterSelectScene"); // 여기에 실제 이동할 씬 이름을 적습니다.
    }
}
