using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    [SerializeField] GameObject pauseMenu;

    void Start()
    {           /*
        pauseMode = GameObject.FindGameObjectsWithTag("ShowWhenPaused");
        resumeMode = GameObject.FindGameObjectsWithTag("ShowWhenResumed");

        foreach (GameObject g in pauseMode)
            g.SetActive(false);*/
        if (pauseMenu == null)
            pauseMenu = GameObject.FindGameObjectWithTag("Pause Menu");
        pauseMenu.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }*/
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false;

    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
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