using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverChecker : MonoBehaviour
{
    private CharaController playerController;

    private string playerTag = "Player";
    private void Start()
    {
        playerController = GameObject.FindGameObjectWithTag(playerTag).GetComponent<CharaController>();
    }

    void Update()
    {
        CheckCondition(CheckPlayer(), CheckBarricate());
    }

    void CheckCondition(bool condition1, bool condition2)
    {
        if(condition1 || condition2)
        {
            Time.timeScale = 0f;
            Invoke("LoadScoreScene", 0f);
        }
    }

    bool CheckPlayer()
    {
        if (playerController != null)
        {
            if(playerController.isDead == true) return true;
        }
        return false;
    }

    bool CheckBarricate()
    {
        return false;
    }

    void LoadScoreScene()
    {
        SceneManager.LoadScene("ScoreScene");
    }
}
