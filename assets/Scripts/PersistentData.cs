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
    [SerializeField] int smallFish;
    [SerializeField] int mediumFish;
    [SerializeField] int largeFish;
    [SerializeField] int month;

    const int playerMoneyStart = 100000;

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
        smallFish = 100;
        mediumFish = 100;
        largeFish = 100;
        month = 5;
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
}
