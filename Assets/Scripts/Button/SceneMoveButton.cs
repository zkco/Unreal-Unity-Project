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

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName.ToString());
    }
}