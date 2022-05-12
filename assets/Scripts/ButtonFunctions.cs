using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ButtonFunctions : MonoBehaviour
{
    int smallFishMoney;
    int mediumFishMoney;
    int largeFishMoney;

    const int fishingpoleCost = 500;
    const int castNetCost = 2000;
    const int fishingBoatCost = 10000;
    const int nightcrawlerCost = 500;
    const int squidCost = 2500;
    const int mackrelCost = 5000;

    const int SMALL_FISH_SELL_PRICE = 50;
    const int MEDIUM_FISH_SELL_PRICE = 100;
    const int LARGE_FISH_SELL_PRICE = 150;

    [SerializeField] GameObject fishKeeper;
    [SerializeField] GameObject moneyKeeper;
    [SerializeField] GameObject eventController;
    [SerializeField] GameObject LandAndPierTrigger;
    [SerializeField] GameObject[] fishingButtons;
    [SerializeField] TMP_InputField playerNameInput;
    int levelNum;
    int curMonth;
    //[SerializeField] InputField playerNameInput;

    const int SMALL_BAIT_MOD = 2;
    const int MEDIUM_BAIT_MOD = 2;
    const int LARGE_BAIT_MOD = 4;
    

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
        if(fishKeeper == null)
        {
            fishKeeper = GameObject.FindGameObjectWithTag("FishKeeper");
        }
        if(fishingButtons == null)
        {
            fishingButtons = GameObject.FindGameObjectsWithTag("AtFishingSpotButtons");
        }

        foreach(GameObject g in fishingButtons)
        {
            g.SetActive(true);
        }
        curMonth = PersistentData.Instance.GetMonth();

        smallFishMoney = 0;
        mediumFishMoney = 0;
        largeFishMoney = 0;
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
        if (!PersistentData.Instance.GetHasFishingPole())
        {
            PersistentData.Instance.SetHasFishingPole(true);
            SubtractMoney(fishingpoleCost);
        }
        
    }
    public void BuyCastNetButton()
    {
        if (!PersistentData.Instance.GetHasCastNet())
        {
            PersistentData.Instance.SetHasCastNet(true);
            SubtractMoney(castNetCost);
        }

    }
    public void BuyBoatButton()
    {
        if (!PersistentData.Instance.GetHasFishingBoat())
        {
            PersistentData.Instance.SetHasFishingBoat(true);
            SubtractMoney(fishingBoatCost);
        }
    }
    public void BuyNightcrawlersButton()
    {
        if (!PersistentData.Instance.GetHasNightcrawlers())
        {
            PersistentData.Instance.SetHasNightcrawlers(true);
            SubtractMoney(nightcrawlerCost);
        }
    }

    public void BuySquidButton()
    {
        if (!PersistentData.Instance.GetHasSquid())
        {
            PersistentData.Instance.SetHasSquid(true);
            SubtractMoney(squidCost);
        }
    }
    public void BuyMackrelButton()
    {
        if (!PersistentData.Instance.GetHasMackrel())
        {
            PersistentData.Instance.SetHasMackrel(true);
            SubtractMoney(mackrelCost);
        }
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
        bool isNonEdu = eventController.GetComponent<EducationEvents>().GetIsNonEduEvent();
        if (isNonEdu)
        {
            int eventNum = eventController.GetComponent<EducationEvents>().GetEventNum();

            if(eventNum == 1)
            {
                PersistentData.Instance.SetHasFishingPole(false);
            }
            else if(eventNum == 2)
            {
                PersistentData.Instance.SetSmallFishCaughtLM( PersistentData.Instance.GetSmallFishCaughtLM() / SMALL_BAIT_MOD);
                PersistentData.Instance.SetMediumFishCaughtLM(PersistentData.Instance.GetMediumFishCaughtLM() / MEDIUM_BAIT_MOD);
                PersistentData.Instance.SetLargeFishCaughtLM(PersistentData.Instance.GetLargeFishCaughtLM() / LARGE_BAIT_MOD);
            }

            else if(eventNum == 3)
            {
                PersistentData.Instance.SetHasCastNet(false);
            }

            else if(eventNum == 4)
            {
                FinalizeFishAmounts();
                PersistentData.Instance.SetSmallFishCaughtLM(0);
                PersistentData.Instance.SetMediumFishCaughtLM(0);
                PersistentData.Instance.SetLargeFishCaughtLM(0);

            }
            else if(eventNum == 5)
            {
                PersistentData.Instance.SetHasFishingBoat(false);
            }
        }
        FinalizeFishAmounts();
        FinalizePlayerMoney();
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

    void SubtractMoney(int cost)
    {
        moneyKeeper.GetComponent<MoneyKeeper>().SubtractMoney(cost);
    }

    void FinalizeFishAmounts()
    {
        PersistentData.Instance.SetSmallFish(PersistentData.Instance.GetSmallFishCaughtLM());
        PersistentData.Instance.SetMediumFish(PersistentData.Instance.GetMediumFishCaughtLM());
        PersistentData.Instance.SetLargeFish(PersistentData.Instance.GetLargeFishCaughtLM());

        //set bait to 0
        PersistentData.Instance.SetHasNightcrawlers(false);
        PersistentData.Instance.SetHasSquid(false);
        PersistentData.Instance.SetHasMackrel(false);

    }

    void FinalizePlayerMoney()
    {
        smallFishMoney = PersistentData.Instance.GetSmallFishCaughtLM() * SMALL_FISH_SELL_PRICE;
        mediumFishMoney = PersistentData.Instance.GetMediumFishCaughtLM() * MEDIUM_FISH_SELL_PRICE;
        largeFishMoney = PersistentData.Instance.GetLargeFishCaughtLM() * LARGE_FISH_SELL_PRICE;

        PersistentData.Instance.SetMoneyMadeLastMonth(smallFishMoney + mediumFishMoney + largeFishMoney);

        int curMoney = PersistentData.Instance.GetMoney();
        PersistentData.Instance.SetMoney(curMoney - (smallFishMoney + mediumFishMoney + largeFishMoney));
    }

    public void StartEvents()
    {
        fishKeeper.GetComponent<FishKeeper>().CatchFish();
        eventController.GetComponent<EducationEvents>().StartEvents();
    }

    public void GoBack()
    {
        SceneManager.LoadScene("Land&Pier");
    }

    public void StartFishing()
    {
        foreach(GameObject g in fishingButtons)
        {
            g.SetActive(false);
        }
        StartEvents();
    }
}
