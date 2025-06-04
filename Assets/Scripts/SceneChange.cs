using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
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
        // SceneManager.LoadScene("Options");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
