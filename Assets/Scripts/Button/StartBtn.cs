using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartBtn : MonoBehaviour
{
    public void OnGameStartBtnScene()
    {
        SceneManager.LoadScene("TitleScene"); // 여기에 실제 이동할 씬 이름을 적습니다.
    }
}
