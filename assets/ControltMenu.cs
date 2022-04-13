using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControltMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMode;
    [SerializeField] private GameObject pauseButton;

    public void GameInstruction()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMode.SetActive(true);
        pauseButton.SetActive(false);

    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pauseMode.SetActive(false);
        pauseButton.SetActive(true);

    }


}
