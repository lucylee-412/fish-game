using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EduAndBuy : MonoBehaviour
{
    [SerializeField] GameObject[] fishPoleButton;
    [SerializeField] GameObject[] castNetButton;
    [SerializeField] GameObject[] fishBoatButton;
    [SerializeField] GameObject[] nightcrawlerButton;
    [SerializeField] GameObject[] squidButton;
    [SerializeField] GameObject[] mackrelButton;
    [SerializeField] GameObject moneyAmt;


    private void Awake()
    {
        moneyAmt = GameObject.FindGameObjectWithTag("TriggerCanvas");
        moneyAmt.SetActive(true);
        fishPoleButton = GameObject.FindGameObjectsWithTag("BuyFishPoleButton");
        castNetButton = GameObject.FindGameObjectsWithTag("BuyCastNetButton");
        nightcrawlerButton = GameObject.FindGameObjectsWithTag("BuyNightcrawlersButton");
        squidButton = GameObject.FindGameObjectsWithTag("BuySquidButton");
        mackrelButton = GameObject.FindGameObjectsWithTag("BuyMackrelButton");
        fishBoatButton = GameObject.FindGameObjectsWithTag("BoatShopVersion");


        DisplayGameObject(fishPoleButton);
        DisplayGameObject(castNetButton);
        DisplayGameObject(nightcrawlerButton);
        DisplayGameObject(squidButton);
        DisplayGameObject(mackrelButton);
        DisplayGameObject(fishBoatButton);

    }

    // Start is called before the first frame update
    void Start()
    {

        RemoveGameObjectDisplay(fishPoleButton);
        RemoveGameObjectDisplay(castNetButton);
        RemoveGameObjectDisplay(nightcrawlerButton);
        RemoveGameObjectDisplay(squidButton);
        RemoveGameObjectDisplay(mackrelButton);
        RemoveGameObjectDisplay(fishBoatButton);


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DisplayGameObject(GameObject[] gameObjectName)
    {
        foreach (GameObject g in gameObjectName)
        {
            g.SetActive(true);
        }

    }
    public void RemoveGameObjectDisplay(GameObject[] gameObjectName)
    {
        foreach (GameObject g in gameObjectName)
        {
            g.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (this.gameObject.tag == "Fishing Pole")
        {
            DisplayGameObject(fishPoleButton);
        }
        if (this.gameObject.tag == "Cast Net")
        {
            DisplayGameObject(castNetButton);
        }
        else if (this.gameObject.tag == "Nightcrawler")
        {
            DisplayGameObject(nightcrawlerButton);
        }
        else if (this.gameObject.tag == "Squid")
        {
            DisplayGameObject(squidButton);
        }
        else if (this.gameObject.tag == "Mackrel")
        {
            DisplayGameObject(mackrelButton);
        }
        else if (this.gameObject.tag == "Boat")
        {
            DisplayGameObject(fishBoatButton);
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (this.gameObject.tag == "Fishing Pole")
        {
            RemoveGameObjectDisplay(fishPoleButton);

        }
        else if (this.gameObject.tag == "Cast Net")
        {
            RemoveGameObjectDisplay(castNetButton);
        }
        else if (this.gameObject.tag == "Nightcrawler")
        {
            RemoveGameObjectDisplay(nightcrawlerButton);
        }
        else if (this.gameObject.tag == "Squid")
        {
            RemoveGameObjectDisplay(squidButton);
        }
        else if (this.gameObject.tag == "Mackrel")
        {
            RemoveGameObjectDisplay(mackrelButton);
        }
        else if (this.gameObject.tag == "Boat")
        {
            RemoveGameObjectDisplay(fishBoatButton);
        }
    }
}
