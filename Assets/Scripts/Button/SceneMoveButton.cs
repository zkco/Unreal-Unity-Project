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
        None,
    }
    public SceneName sceneName;

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName.ToString());
    }
}