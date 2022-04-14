using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    [SerializeField] InputField playerNameInput;
    [SerializeField] int money;
    Equipment fishPoleTest;
    int tempMoney;
    MoneyKeeper moneyKeeper;
    // Start is called before the first frame update
    void Start()
    {
        if (fishPoleTest == null)
            fishPoleTest = GameObject.Find("Fishing Pole").GetComponent<Equipment>();
        money = PersistentData.Instance.GetMoney();
        tempMoney = fishPoleTest.GetFishPoleCost();
        moneyKeeper = GameObject.FindGameObjectWithTag("GameController").GetComponent<MoneyKeeper>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void PlayGame()
    {
        string s = playerNameInput.text;
        PersistentData.Instance.SetName(s);
        SceneManager.LoadScene("Land&Pier");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BuyFishingPoleButton()
    {
        moneyKeeper.SubtractMoney(500);
        
    }

}
