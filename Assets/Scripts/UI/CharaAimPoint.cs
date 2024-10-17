using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaAimPoint : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private RectTransform imageRectTransform;

    private Camera mainCamera;
    private CharaController controller;

    private float distanceMax = 17f;

    private void Awake()
    {
        mainCamera = Camera.main;
        controller = GetComponent<CharaController>();
    }

    private void Start()
    {
        controller.OnAimEvent += UpdateFillAmount;
    }

    public void UpdateFillAmount(Vector2 mousePos)
    {
        float distance = Vector2.Distance(bulletSpawnPoint.position, mousePos);
        distance = Mathf.Clamp(distance, distance, distanceMax);

        Vector2 direction = (mousePos - (Vector2)bulletSpawnPoint.position).normalized;
        imageRectTransform.sizeDelta = new Vector2(distance, imageRectTransform.sizeDelta.y);
    }
}
