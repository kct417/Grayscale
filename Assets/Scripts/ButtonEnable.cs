using UnityEngine;

public class ButtonEnable : MonoBehaviour
{
    public GameObject objectToEnable;
    public Vector3 fixedPosition = new Vector3(0, 0, 0); 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && objectToEnable != null)
        {
            objectToEnable.SetActive(false);
        }
    }

    public void EnableTarget()
    {
        if (objectToEnable != null)
        {
            objectToEnable.SetActive(true);
            objectToEnable.transform.position = fixedPosition;
        }
    }
}