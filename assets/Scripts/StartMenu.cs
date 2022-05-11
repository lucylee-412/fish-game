using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Bait&TackleShop");
    }

    public void Instruction()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Close()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
