using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectorButton : MonoBehaviour
{
    [SerializeField] private Sprite sprite;
    [SerializeField] private Image image;

    public void Start()
    {
        sprite = GetComponent<Image>().sprite;
    }
    public void ChangeCharacter()
    {
        image.sprite = sprite;
    }
}