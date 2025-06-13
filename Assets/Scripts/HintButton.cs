using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class HintButton : MonoBehaviour
{
    private bool isHintButtonOpen = false;
    public GameObject hintPanel;

    private void Start()
    {
        hintPanel.SetActive(isHintButtonOpen);
    }

    public void ToggleHintPanel()
    {
        isHintButtonOpen = !isHintButtonOpen;
        hintPanel.SetActive(isHintButtonOpen);
    }

}
