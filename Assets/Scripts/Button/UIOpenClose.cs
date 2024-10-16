using UnityEngine;

public class UIOpenClose : MonoBehaviour
{
    public GameObject obj;

    public void OpenUI()
    {
        obj.SetActive(true);
    }

    public void CloseUI()
    {
        obj.SetActive(false);
    }
}