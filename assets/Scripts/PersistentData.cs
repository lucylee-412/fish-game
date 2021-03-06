using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [SerializeField] int playerMoney;
    [SerializeField] string playerName;
    [SerializeField] bool hasFishingPole;
    [SerializeField] bool hasCastNet;
    [SerializeField] bool hasFishingBoat;
    [SerializeField] bool hasNightcrawlers;
    [SerializeField] bool hasSquid;
    [SerializeField] bool hasMackrel;
    [SerializeField] bool welcomeStoryDisplayed;
    [SerializeField] bool criminalActivity;
    [SerializeField] int smallFish;
    [SerializeField] int mediumFish;
    [SerializeField] int largeFish;
    [SerializeField] int month;
    [SerializeField] int smallFishCaughtLastMonth;
    [SerializeField] int mediumFishCaughtLastMonth;
    [SerializeField] int largeFishCaughtLastMonth;
    [SerializeField] int moneyMadeLastMonth;

    const int playerMoneyStart = 1000;
    const int smallFishStart = 250;
    const int mediumFishStart = 200;
    const int largeFishStart = 150;
    bool fromMainMenuOnly;

    public static PersistentData Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        playerMoney = playerMoneyStart;
        playerName = "";
        hasFishingPole = false;
        hasCastNet = false;
        hasFishingBoat = false;
        hasNightcrawlers = false;
        hasSquid = false;
        hasMackrel = false;
        smallFish = smallFishStart;
        mediumFish = mediumFishStart;
        largeFish = largeFishStart;
        month = 1;
        welcomeStoryDisplayed = false;
        criminalActivity = false;
        fromMainMenuOnly = false;

        smallFishCaughtLastMonth = 0;
        mediumFishCaughtLastMonth = 0;
        largeFishCaughtLastMonth = 0;
        moneyMadeLastMonth = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetName(string s)
    {
        playerName = s;
    }

    public void SetMoney(int m)
    {
        playerMoney = m;
    }

    public string GetName()
    {
        return playerName;
    }

    public int GetMoney()
    {
        return playerMoney;
    }
    
    public void SetHasFishingPole(bool value)
    {
        hasFishingPole = value;
    }

    public bool GetHasFishingPole()
    {
        return hasFishingPole;
    }
    public void SetHasCastNet(bool value)
    {
        hasCastNet = value;
    }

    public bool GetHasCastNet()
    {
        return hasCastNet;
    }
    
    public void SetHasNightcrawlers(bool value)
    {
        hasNightcrawlers = value;
    }

    public bool GetHasNightcrawlers()
    {
        return hasNightcrawlers;
    }
    public void SetHasSquid(bool value)
    {
        hasSquid = value;
    }

    public bool GetHasSquid()
    {
        return hasSquid;
    }

    public void SetHasMackrel(bool value)
    {
        hasMackrel = value;
    }

    public bool GetHasMackrel()
    {
        return hasMackrel;
    }
    public void SetHasFishingBoat(bool value)
    {
        hasFishingBoat = value;
    }

    public bool GetHasFishingBoat()
    {
        return hasFishingBoat;
    }

    public void SetSmallFish(int sf)
    {
        smallFish = sf;
    }

    public int GetSmallFish()
    {
        return smallFish;
    }

    public void SetMediumFish(int mf)
    {
        mediumFish = mf;
    }

    public int GetMediumFish()
    {
        return mediumFish;
    }

    public void SetLargeFish(int lf)
    {
        largeFish = lf;
    }

    public int GetLargeFish()
    {
        return largeFish;
    }

    public void SetMonth(int m)
    {
        month = m;
    }

    public int GetMonth()
    {
        return month;
    }

    public void SetMoneyMadeLastMonth(int money)
    {
        moneyMadeLastMonth = money;
    }

    public int GetMoneyMadeLastMonth()
    {
        return moneyMadeLastMonth;
    }

    public void SetSmallFishCaughtLM(int smFish)
    {
        smallFishCaughtLastMonth = smFish;
    }
    public int GetSmallFishCaughtLM()
    {
        return smallFishCaughtLastMonth;
    }
    public void SetMediumFishCaughtLM(int medFish)
    {
        mediumFishCaughtLastMonth = medFish;
    }

    public int GetMediumFishCaughtLM()
    {
        return mediumFishCaughtLastMonth;
    }
    public void SetLargeFishCaughtLM(int largeFish)
    {
        largeFishCaughtLastMonth = largeFish;
    }
    public int GetLargeFishCaughtLM()
    {
        return largeFishCaughtLastMonth;
    }
    public void SubtractFromSmallFish(int amt)
    {
        if(smallFish - amt > 0)
        {
            smallFish -= amt;
        }
        else
        {
            SetSmallFish(0);
        }
    }
    public void AddToSmallFish(int amt)
    {
        if (smallFish + amt < smallFishStart)
        {
            smallFish += amt;
        }
        else
        {
            smallFish = smallFishStart;
        }
    }

    public void SubtractFromMedFish(int amt)
    {
        if (mediumFish - amt > 0)
        {
            mediumFish -= amt;
        }
        else
        {
            mediumFish = 0;
        }
    }
    public void AddToMedFish(int amt)
    {
        if (mediumFish + amt < mediumFishStart)
        {
            mediumFish += amt;
        }
        else
        {
            mediumFish = mediumFishStart;
        }
    }
    public void SubtractFromLargeFish(int amt)
    {
        if (largeFish - amt > 0)
        {
            largeFish -= amt;
        }
        else
        {
            largeFish = 0;
        }
    }
    public void AddToLargeFish(int amt)
    {
        if(largeFish + amt < largeFishStart)
        {
            largeFish += amt;
        }
        else
        {
            largeFish = largeFishStart;
        }
    }

    public void ZeroFishCaughtLM()
    {
        smallFishCaughtLastMonth = 0;
        mediumFishCaughtLastMonth = 0;
        largeFishCaughtLastMonth = 0;
    }

    public float GetCurrentSmallFishPercentage()
    {
        return ((float)smallFish / (float)smallFishStart);
    }
    public float GetCurrentMedFishPercentage()
    {
        return ((float)mediumFish / (float)mediumFishStart);
    }
    public float GetCurrentLargeFishPercentage()
    {
        return ((float)largeFish / (float)largeFishStart);
    }
    public float GetCurrentTotalFishPercentage()
    {
        return ((float)smallFish + (float)mediumFish + (float)largeFish) / ((float)smallFishStart + (float)mediumFishStart + (float)largeFishStart);
    }
    public void SetWelcomeStory(bool val)
    {
        welcomeStoryDisplayed = val;
    }
    public bool GetWelcomeStory()
    {
        return welcomeStoryDisplayed;
    }


    public void SetCriminalActivity(bool val)
    {
        criminalActivity = val;
    }

    public bool GetCriminalActivity()
    {
        return criminalActivity;
    }

    public void AddProfitTransitonScene(int val)
    {
        playerMoney += val;
    }

    public void SetFromMainMenuOnly( bool val)
    {
        fromMainMenuOnly = val;
    }
    public bool GetFromMainMenuOnly()
    {
        return fromMainMenuOnly;
    }
    public void EndGameInstance()
    {
        Destroy(this);
    }

}
