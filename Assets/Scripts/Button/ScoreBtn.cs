using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreBtn : MonoBehaviour
{
    public void ScoreScene()
    {
        SceneManager.LoadScene("ScoreScene"); // 여기에 실제 이동할 씬 이름을 적습니다.
    }
}
