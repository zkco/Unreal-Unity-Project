using UnityEngine;

public class CharaAimLine : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private Transform aimPoint;
    [SerializeField] private RectTransform imageRectTransform;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        UpdateAimLine((Vector2)aimPoint.transform.position);
    }

    public void UpdateAimLine(Vector2 pointPos)
    {
        float distance = Vector2.Distance(pointPos, bulletSpawnPoint.position);
        Vector2 direction = (pointPos - (Vector2)bulletSpawnPoint.position);
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        imageRectTransform.sizeDelta = new Vector2(distance-0.55f, imageRectTransform.sizeDelta.y);
        imageRectTransform.rotation = Quaternion.Euler(0,0,rotZ);
    }
}
