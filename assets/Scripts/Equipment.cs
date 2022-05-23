using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipment : MonoBehaviour
{
    [SerializeField] GameObject fishingPole;
    [SerializeField] GameObject castNet;
    [SerializeField] GameObject fishingBoat;
    [SerializeField] GameObject nightcrawlerBait;
    [SerializeField] GameObject squidBait;
    [SerializeField] GameObject mackrelBait;

    const int fishPoleCost = 500;
    const int castNetCost = 1000;
    const int fishingBoatCost = 10000;
    const int nightcrawlerCost = 250;
    const int squidCost = 1000;
    const int mackrelCost = 2500;


    // Start is called before the first frame update
    void Start()
    {
        if (fishingPole == null)
            fishingPole = GameObject.FindGameObjectWithTag("Fishing Pole");
        if (castNet == null)
            castNet = GameObject.FindGameObjectWithTag("Cast Net");
        if (nightcrawlerBait == null)
            nightcrawlerBait = GameObject.FindGameObjectWithTag("Nightcrawler");
        if (squidBait == null)
            squidBait = GameObject.FindGameObjectWithTag("Squid");
        if (mackrelBait == null)
            mackrelBait = GameObject.FindGameObjectWithTag("Mackrel");
        if(fishingBoat == null)
        {
            fishingBoat = GameObject.FindGameObjectWithTag("Boat");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int GetFishPoleCost()
    {
        return fishPoleCost;
    }
    public int GetCastNetCost()
    {
        return castNetCost;
    }
    public int GetFishingBoat()
    {
        return fishingBoatCost;
    }
    public int GetNightcrawlerCost()
    {
        return nightcrawlerCost;
    }
    public int GetSquidCost()
    {
        return squidCost;
    }
    public int GetMackrelCost()
    {
        return mackrelCost;
    }
    
}
