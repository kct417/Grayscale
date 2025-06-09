using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject optionsPanel;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && optionsPanel.activeSelf)
        {
            optionsPanel.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && !optionsPanel.activeSelf)
        {
            optionsPanel.SetActive(true);
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void Options()
    {
        optionsPanel.SetActive(true);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
