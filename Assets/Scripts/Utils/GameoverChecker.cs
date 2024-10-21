using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverChecker : MonoBehaviour
{
    [SerializeField]private CharaController cowboy01Controller;
    [SerializeField]private CharaController cowboy02Controller;
    private Barricade barricade;

    private string playerTag = "Player";

    private void Start()
    {
        barricade = GameObject.FindGameObjectWithTag("Finish").GetComponent<Barricade>();
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
        
        if (cowboy01Controller != null || cowboy02Controller !=null)
        {
            if(cowboy01Controller.isDead == true || cowboy02Controller.isDead == true) return true;
        }
        return false;
    }

    bool CheckBarricate()
    {
        if (barricade != null)
        {
            if(barricade.isTouched == true) return true;
        }
        return false;
    }

    void LoadScoreScene()
    {
        SceneManager.LoadScene("ScoreScene");
        SoundManager.Instance.PlayBgm("OtherSceneBGM");
        Time.timeScale = 1f;
    }
}
