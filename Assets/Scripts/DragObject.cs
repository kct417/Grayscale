using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 offset;
    private bool mouseDrag = false;

    void OnMouseDown()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - new Vector3(mouseWorldPos.x, mouseWorldPos.y, transform.position.z);
        mouseDrag = true;
    }

    void OnMouseDrag()
    {
        if (mouseDrag)
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, transform.position.z) + offset;
        }
    }

    void OnMouseUp()
    {
        mouseDrag = false;
    }
}