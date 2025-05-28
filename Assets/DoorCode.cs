using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class DoorCode : MonoBehaviour
{
    public TMP_Text inputDisplay; 
    private string currentInput = "";
    private string correctCode = "14"; 

    public void OnNumberButtonPressed(string number)
    {
        if (currentInput.Length < 4)
        {
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
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Incorrect");
        }
        currentInput = "";
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        inputDisplay.text = string.Join("   ", currentInput.ToCharArray());
    }
}
