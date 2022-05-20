using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseResumeMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    [SerializeField] GameObject pauseMode;
    [SerializeField] GameObject playMode;


    void Awake()
    {
        pauseMode = GameObject.FindGameObjectWithTag("Pause Mode");
        playMode = GameObject.FindGameObjectWithTag("Play Mode");


        pauseMode.SetActive(true);
        playMode.SetActive(true);

    }

    void Start()
    {
        Resume();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        if (GameIsPaused == true)
        {
            AudioListener.volume = 0.0f; // Mute audio on pause
        }
        else
        {
            AudioListener.volume = 1.0f;
        }
    }

    public void Resume()
    {
        // Disable pause mode
        pauseMode.SetActive(false);
        // Re-enable play mode
        playMode.SetActive(true);

        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        // Disable play mode
        playMode.SetActive(false);
        // Re-enable pause mode
        pauseMode.SetActive(true);

        Time.timeScale = 0.0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}