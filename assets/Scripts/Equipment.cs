using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipment : MonoBehaviour
{
    [SerializeField] GameObject fishingPole;
    [SerializeField] GameObject castNet;
    [SerializeField] GameObject nightcrawlerBait;
    [SerializeField] GameObject squidBait;
    [SerializeField] GameObject mackrelBait;
    //[SerializeField] GameObject fishPoleText;
    //[SerializeField] GameObject fishPoleButton;
    const int fishPoleCost = 500;
    const int castNetCost = 1000;
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
        
        /*fishPoleButton = GameObject.FindGameObjectWithTag("BuyFishPoleButton");
        fishPoleText = GameObject.FindGameObjectWithTag("FishingPoleEduText");
        fishPoleButton.SetActive(false);
        fishPoleText.SetActive(false);*/
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyFishPole()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(this.gameObject.tag == "Fishing Pole")
        {
            Debug.Log("This is the fishing pole!");
            GameObject fishPoleButton = GameObject.FindGameObjectWithTag("BuyFishPoleButton");
            GameObject fishPoleText = GameObject.FindGameObjectWithTag("FishingPoleEduText");
            fishPoleButton.SetActive(true);
            fishPoleText.SetActive(true);
        }
        else if (this.gameObject.tag == "Cast Net")
        {
            Debug.Log("You got the right one bub!");
        }
        else if (this.gameObject.tag == "Nightcrawler")
        {
            Debug.Log("You got the right one bub!");
        }
        else if (this.gameObject.tag == "Squid")
        {
            Debug.Log("You got the right one bub!");
        }
        else if (this.gameObject.tag == "Mackrel")
        {
            Debug.Log("You got the right one bub!");
        }
    }
}
