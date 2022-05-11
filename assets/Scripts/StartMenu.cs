using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] InputField playerNameInput;

    public void PlayGame()
    {
        string s = playerNameInput.text;
        PersistentData.Instance.SetName(s);
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


