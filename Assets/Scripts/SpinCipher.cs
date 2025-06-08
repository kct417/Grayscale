using UnityEngine;
using UnityEngine.EventSystems;

public class SpinUI : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private RectTransform rectTransform;
    private Vector2 centerScreenPos;
    private float lastAngle;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        centerScreenPos = RectTransformUtility.WorldToScreenPoint(eventData.pressEventCamera, rectTransform.position);
        lastAngle = GetAngle(eventData.position);
    }

    public void OnDrag(PointerEventData eventData)
    {
        float currentAngle = GetAngle(eventData.position);
        float deltaAngle = Mathf.DeltaAngle(lastAngle, currentAngle);

        rectTransform.Rotate(0, 0, deltaAngle);

        lastAngle = currentAngle;
    }

    private float GetAngle(Vector2 pointerPos)
    {
        Vector2 dir = pointerPos - centerScreenPos;
        return Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    }
}