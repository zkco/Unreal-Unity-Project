using UnityEngine;
using UnityEngine.UI;

public class DifficultySelector : MonoBehaviour
{    
    public enum Difficulty
    {
        Normal,
        Hard
    }
    public void SelectNormalDifficulty()
    {
        PlayerPrefs.SetInt("GameDifficulty", (int)Difficulty.Normal);
        Debug.Log("Normal Difficulty Selected");
        // ���� ���� �ε��ϰų� �ٸ� �۾��� �߰��� �� �ֽ��ϴ�.
    }

    // �� �Լ��� Hard ���̵��� �������� �� ȣ��˴ϴ�.
    public void SelectHardDifficulty()
    {
        PlayerPrefs.SetInt("GameDifficulty", (int)Difficulty.Hard);
        Debug.Log("Hard Difficulty Selected");
        // ���� ���� �ε��ϰų� �ٸ� �۾��� �߰��� �� �ֽ��ϴ�.
    }
}
