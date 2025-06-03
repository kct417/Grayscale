using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public float ScrollSpeed = 100f;

    private RectTransform rectTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rectTransform.anchoredPosition.y < rectTransform.rect.height)
        {
            rectTransform.anchoredPosition += new Vector2(0, ScrollSpeed * Time.deltaTime);
        }
        else {
            SceneManager.LoadScene("Menu");
        }
    }
}
