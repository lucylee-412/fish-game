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
    [SerializeField] GameObject eventController;
    [SerializeField] GameObject LandAndPierTrigger;
    int levelNum;
    int curMonth;
    //[SerializeField] InputField playerNameInput;


    // Start is called before the first frame update
    void Start()
    {
        if(moneyKeeper == null)
        {
            moneyKeeper = GameObject.FindGameObjectWithTag("GameController");
        }
        levelNum = SceneManager.GetActiveScene().buildIndex;

        if(levelNum >= 4)
        {
            eventController = GameObject.FindGameObjectWithTag("Event Trigger");
        }
        if (LandAndPierTrigger == null)
        {
            LandAndPierTrigger = GameObject.FindGameObjectWithTag("PierFishingSpot");
        }
        curMonth = PersistentData.Instance.GetMonth();
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
            PersistentData.Instance.SetHasFishingPole(true);
            moneyKeeper.GetComponent<MoneyKeeper>().SubtractMoney(fishingpoleCost);
        }
        
    }
    public void BuyCastNetButton()
    {
        if (!PersistentData.Instance.GetHasCastNet())
        {
            PersistentData.Instance.SetHasCastNet(true);
            moneyKeeper.GetComponent<MoneyKeeper>().SubtractMoney(castNetCost);
        }

    }
    public void BuyBoatButton()
    {
        if (!PersistentData.Instance.GetHasFishingBoat())
        {
            PersistentData.Instance.SetHasFishingBoat(true);
            moneyKeeper.GetComponent<MoneyKeeper>().SubtractMoney(fishingBoatCost);
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


    public void GoFishingWithPole()
    {
        LandAndPierTrigger.GetComponent<LandAndPierTriggers>().SetAllButtonsFalse();
        SceneManager.LoadScene("FishingPole");
    }

    public void GoFishingWithCastNet()
    {
        LandAndPierTrigger.GetComponent<LandAndPierTriggers>().SetAllButtonsFalse();
        SceneManager.LoadScene("CastNet");
    }

    public void GoFishingOnOcean()
    {
        LandAndPierTrigger.GetComponent<LandAndPierTriggers>().SetAllButtonsFalse();
        SceneManager.LoadScene("OceanFishing");
    }

    public void AcceptEvent()
    {
        int eventNum = eventController.GetComponent<EducationEvents>().GetEventNum();

        //below we will need to populate effects to events
        if(eventNum == 1)
        {
            eventController.GetComponent<EducationEvents>().ShowEducation(eventNum);
        }
        else if (eventNum == 2)
        {
            eventController.GetComponent<EducationEvents>().ShowEducation(eventNum);
        }
        else if (eventNum == 3)
        {
            eventController.GetComponent<EducationEvents>().ShowEducation(eventNum);
        }
        else if (eventNum == 4)
        {
            eventController.GetComponent<EducationEvents>().ShowEducation(eventNum);
        }
        else if (eventNum == 5)
        {
            eventController.GetComponent<EducationEvents>().ShowEducation(eventNum);
        }
    }

    public void DeclineEvent()
    {
        int eventNum = eventController.GetComponent<EducationEvents>().GetEventNum();

        //below we will need to populate effects to events
        if (eventNum == 1)
        {
            eventController.GetComponent<EducationEvents>().ShowEducation(eventNum);
        }
        else if (eventNum == 2)
        {
            eventController.GetComponent<EducationEvents>().ShowEducation(eventNum);
        }
        else if (eventNum == 3)
        {
            eventController.GetComponent<EducationEvents>().ShowEducation(eventNum);
        }
        else if (eventNum == 4)
        {
            eventController.GetComponent<EducationEvents>().ShowEducation(eventNum);
        }
        else if (eventNum == 5)
        {
            eventController.GetComponent<EducationEvents>().ShowEducation(eventNum);
        }
    }

    public void OkEvent()
    {
        SceneManager.LoadScene("MonthTransition");
    }
    public void AdvanceTime()
    {
        if(curMonth < 12)
        {
            PersistentData.Instance.SetMonth(curMonth + 1);
            SceneManager.LoadScene("Land&Pier");
        }
        else
        {
            SceneManager.LoadScene("HighScores");
        }
    }
}
