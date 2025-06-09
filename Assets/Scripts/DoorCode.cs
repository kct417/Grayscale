using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class DoorCode : MonoBehaviour
{
    public TMP_Text inputDisplay;
    public GameObject door;
    private string currentInput = "";
    private string correctCode = "5413";

    public PlayerMovement playerMovement;

    private AudioSource audioSource;
    public AudioClip clickNoise;
    public AudioClip correctNoise;
    public AudioClip wrongNoise;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnNumberButtonPressed(string number)
    {
        if (currentInput.Length < 4)
        {
            audioSource.PlayOneShot(clickNoise);
            currentInput += number;
            UpdateDisplay();
        }
    }

    public void OnBackspacePressed()
    {
        if (currentInput.Length > 0)
        {
            currentInput = currentInput.Substring(0, currentInput.Length - 1);
            UpdateDisplay();
        }
    }

    public void OnEnterPressed()
    {
        string trimmedInput = currentInput.TrimStart('0');
        if (trimmedInput == correctCode)
        {
            audioSource.PlayOneShot(correctNoise);
            StartCoroutine(DelayOpen(1f));
        }
        else
        {
            audioSource.PlayOneShot(wrongNoise);
        }
        currentInput = "";
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        inputDisplay.text = string.Join("   ", currentInput.ToCharArray());
    }

    private IEnumerator DelayOpen(float delay)
    {
        yield return new WaitForSeconds(delay);
        playerMovement.SetMove(true);
        door.SetActive(false);
        gameObject.SetActive(false);
    } 
}
