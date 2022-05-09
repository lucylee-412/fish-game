using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    [SerializeField] GameObject moneyKeeper;
    const int fishingpoleCost = 500;
    const int castNetCost = 2000;
    const int fishingBoatCost = 10000;
    const int nightcrawlerCost = 500;
    const int squidCost = 2500;
    const int mackrelCost = 5000;
    //[SerializeField] InputField playerNameInput;


    // Start is called before the first frame update
    void Start()
    {
        if(moneyKeeper == null)
        {
            moneyKeeper = GameObject.FindGameObjectWithTag("GameController");
        }
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
        SceneManager.LoadScene("Land&Pier");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BuyFishingPoleButton()
    {
        if (!PersistentData.Instance.GetHasFishingPole())
        {
            PersistentData.Instance.SetHasFishingPole();
            moneyKeeper.GetComponent<MoneyKeeper>().SubtractMoney(fishingpoleCost);
        }
        
    }
    public void BuyCastNetButton()
    {
        if (!PersistentData.Instance.GetHasCastNet())
        {
            PersistentData.Instance.SetHasCastNet();
            moneyKeeper.GetComponent<MoneyKeeper>().SubtractMoney(castNetCost);
        }

    }
    public void BuyNightcrawlersButton()
    {
        moneyKeeper.GetComponent<MoneyKeeper>().SubtractMoney(nightcrawlerCost);
    }

    public void BuySquidButton()
    {
        moneyKeeper.GetComponent<MoneyKeeper>().SubtractMoney(squidCost);
    }
    public void BuyMackrelButton()
    {
        moneyKeeper.GetComponent<MoneyKeeper>().SubtractMoney(mackrelCost);
    }

    public void BuyBoatButton()
    {
        moneyKeeper.GetComponent<MoneyKeeper>().SubtractMoney(fishingBoatCost);
    }

    public void GoFishingWithPole()
    {
        SceneManager.LoadScene("FishingPole");
    }

    public void GoFishingWithCastNet()
    {
        SceneManager.LoadScene("CastNet");
    }

    public void GoFishingOnOcean()
    {
        SceneManager.LoadScene("OceanFishing");
    }
}
