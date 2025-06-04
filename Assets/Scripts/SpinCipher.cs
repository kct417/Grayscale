using UnityEngine;

public class SpinCipher : MonoBehaviour
{
    Camera cam;
    private bool mouseDrag = false;
    private float saveAngle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseDrag)
        {
            Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePos - (Vector2)transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            float angleDelta = Mathf.DeltaAngle(saveAngle, angle);
            transform.Rotate(0, 0, angleDelta);

            saveAngle = angle;

            if (Input.GetMouseButtonUp(0))
            {
                mouseDrag = false;
            }
        }
    }
    
    void OnMouseDown()
    {
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - (Vector2)transform.position;
        saveAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        mouseDrag = true;
    }
}
