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

    int levelNum;
    // Start is called before the first frame update
    void Start()
    {
        levelNum = SceneManager.GetActiveScene().buildIndex;
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
        if(levelNum == 0)
        {
            PersistentData.Instance.SetFromMainMenuOnly(true);
        }
        SceneManager.LoadScene("HighScores");
    }

    public void MainMenu()
    {
        PersistentData.Instance.EndGameInstance();
        SceneManager.LoadScene("StartMenu");
    }

    void DisplayPlayerInfo()
    {
        playerinfo.text = playerName + "'s money: " + playerMoney.ToString();
    }
}
