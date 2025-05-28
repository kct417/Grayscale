using UnityEngine;

public class GameOver : MonoBehaviour
{
    public PlayerMovement moveScript;
    public GameObject gameOverPanel;

    void OnCollisionEnter2D(Collision2D other)
    {
        moveScript.enabled = false; 
        gameOverPanel.SetActive(true); 
    }
}
