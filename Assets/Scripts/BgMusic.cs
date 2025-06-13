using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgMusic : MonoBehaviour
{
    [SerializeField] AudioSource defaultBg;
    [SerializeField] AudioSource gameBg;
    // private string currentScene;

    public static BgMusic audioManager;

    private void Awake()
    {
        // Check that there is only one instance of the audio manager 
        if (audioManager == null) {
            audioManager = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        } else {
            Destroy(gameObject);
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        CheckScene(scene.name);
    }

    private void CheckScene(string sceneName)
    {
        // if (sceneName == "Game")
        // {
        //     defaultBg.Stop();
        //     if (!gameBg.isPlaying)
        //         gameBg.Play();
        // }
        // else
        // {
        //     gameBg.Stop();
        //     if (!defaultBg.isPlaying)
        //         defaultBg.Play();
        // }

        if (!defaultBg.isPlaying)
                defaultBg.Play();
    }

}