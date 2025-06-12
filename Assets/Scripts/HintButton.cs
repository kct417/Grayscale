using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class HintButton : MonoBehaviour
{
    private bool isHintButtonOpen = false;
    public GameObject hintPanel;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ToggleHintPanel);
        
        hintPanel.SetActive(isHintButtonOpen);
    }

    public void ToggleHintPanel()
    {
        isHintButtonOpen = !isHintButtonOpen;
        hintPanel.SetActive(isHintButtonOpen);
    }

}
