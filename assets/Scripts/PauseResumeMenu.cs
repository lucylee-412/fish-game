using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseResumeMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    [SerializeField] GameObject[] pauseMode;
    [SerializeField] GameObject[] playMode;
    [SerializeField] GameObject pauseResumeCanvas;

    void Awake()
    {
        pauseMode = GameObject.FindGameObjectsWithTag("Pause Mode");
        playMode = GameObject.FindGameObjectsWithTag("Play Mode");
        pauseResumeCanvas = GameObject.FindGameObjectWithTag("PuaseResumeCanvas");

        foreach (GameObject g in playMode)
        {
            g.SetActive(true);
        }
        foreach (GameObject g in pauseMode)
        {
            g.SetActive(true);
        }
    }

    void Start()
    {
        foreach (GameObject g in pauseMode)
        {
            g.SetActive(false); // Pause mode starts off and remains inactive until
        }                       // player presses pause button
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
        foreach (GameObject g in pauseMode)
        {
            g.SetActive(false);
        }
        // Re-enable play mode
        foreach (GameObject g in playMode)
        {
            g.SetActive(true);
        }

        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        // Disable play mode
        foreach (GameObject g in playMode)
        {
            g.SetActive(false);
        }
        // Re-enable pause mode
        foreach (GameObject g in pauseMode)
        {
            g.SetActive(true);
        }

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