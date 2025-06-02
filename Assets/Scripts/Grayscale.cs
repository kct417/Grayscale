using UnityEngine;

public class Grayscale : MonoBehaviour
{
    public Material grayscaleMaterial;

    public float duration = 30f; // time in seconds
    public bool loop = false; // rotate between grayscale and normal

    private float timer = 0f;
    private bool fadeIn = true;

    void Start()
    {
        if (grayscaleMaterial == null)
        {
            Debug.LogError("Grayscale material is not assigned.");
            enabled = false;
        }
        else
        {
            grayscaleMaterial.SetFloat("_GrayscaleValue", 0f);
        }
    }

    void Update()
    {
        timer += Time.deltaTime / duration;
        float grayscaleValue = fadeIn ? Mathf.Clamp01(timer) : Mathf.Clamp01(1f - timer);

        grayscaleMaterial.SetFloat("_GrayscaleValue", grayscaleValue);

        if (loop && timer >= 1f)
        {
            timer = 0f;
            fadeIn = !fadeIn;
        }
    }
}
