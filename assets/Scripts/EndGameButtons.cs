using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGameButtons : MonoBehaviour
{
    [SerializeField] TMP_Text playerinfo;
    string playerName;
    int playerMoney;
    // Start is called before the first frame update
    void Start()
    {
        playerName = PersistentData.Instance.GetName();
        playerMoney = PersistentData.Instance.GetMoney();
        DisplayPlayerInfo();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HighScores()
    {
        SceneManager.LoadScene("HighScores");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    void DisplayPlayerInfo()
    {
        playerinfo.text = playerName + "'s money: " + playerMoney.ToString();
    }
}
