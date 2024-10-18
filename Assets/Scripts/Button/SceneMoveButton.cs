using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoveButton : MonoBehaviour
{
    public enum SceneName
    {
        StartScene,
        TitleScene,
        CharacterSelectScene,
        MainScene,
        ScoreScene,
    }
    public SceneName sceneName;
    private string scene;

    private void Awake()
    {
        scene = sceneName.ToString();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName.ToString());
        if(scene == null)
        {
            return;
        }
        else
        {
            if (scene == "MainScene") GameManager.Instance.isPlaying = true;
            else GameManager.Instance.isPlaying = false;
        }
    }
}