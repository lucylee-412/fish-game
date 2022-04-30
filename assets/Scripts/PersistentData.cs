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
    
    public void SetHasFishingPole()
    {
        if(hasFishingPole == false)
        {
            hasFishingPole = true;
        }
        else
        {
            hasFishingPole = false;
        }
    }

    public bool GetHasFishingPole()
    {
        return hasFishingPole;
    }
    public void SetHasCastNet()
    {
        if (hasCastNet == false)
        {
            hasCastNet = true;
        }
        else
        {
            hasCastNet = false;
        }
    }

    public bool GetHasCastNet()
    {
        return hasCastNet;
    }
    public void SetHasFishingBoat()
    {
        if (hasFishingBoat == false)
        {
            hasFishingBoat = true;
        }
        else
        {
            hasFishingBoat = false;
        }
    }

    public bool GetHasFishingBoat()
    {
        return hasFishingBoat;
    }
}
