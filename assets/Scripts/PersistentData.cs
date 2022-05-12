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
    [SerializeField] int smallFish;
    [SerializeField] int mediumFish;
    [SerializeField] int largeFish;
    [SerializeField] int month;
    [SerializeField] int smallFishCaughtLastMonth;
    [SerializeField] int mediumFishCaughtLastMonth;
    [SerializeField] int largeFishCaughtLastMonth;
    [SerializeField] int moneyMadeLastMonth;

    const int playerMoneyStart = 2000;
    const int smallFishStart = 100;
    const int mediumFishStart = 100;
    const int largeFishStart = 100;

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
        month = 5;

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
}
