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
    [SerializeField] GameObject[] fishPoleText;
    [SerializeField] GameObject[] fishPoleButton;
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

        fishPoleButton = GameObject.FindGameObjectsWithTag("BuyFishPoleButton");
        fishPoleText = GameObject.FindGameObjectsWithTag("FishingPoleEduText");

        foreach (GameObject g in fishPoleButton)
        {
            g.SetActive(false);
        }
        foreach (GameObject g in fishPoleText)
        {
            g.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(this.gameObject.tag == "Fishing Pole")
        {
            Debug.Log("This is the fishing pole!");
            foreach (GameObject g in fishPoleButton)
            {
                g.SetActive(true);
            }
            foreach (GameObject g in fishPoleText)
            {
                g.SetActive(true);
            }
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
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (this.gameObject.tag == "Fishing Pole")
        {
            foreach (GameObject g in fishPoleButton)
            {
                g.SetActive(false);
            }
            foreach (GameObject g in fishPoleText)
            {
                g.SetActive(false);
            }
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
