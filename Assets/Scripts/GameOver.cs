using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public PlayerMovement playerMovement;
    
    void OnCollisionEnter2D(Collision2D other)
    {
        playerMovement.SetMove(false);
        gameOverPanel.SetActive(true);
    }
}
