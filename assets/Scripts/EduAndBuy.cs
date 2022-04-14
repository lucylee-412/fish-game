using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EduAndBuy : MonoBehaviour
{
    [SerializeField] GameObject[] fishPoleText;
    [SerializeField] GameObject[] fishPoleButton;
    [SerializeField] GameObject fishingPole;
    [SerializeField] GameObject moneyAmt;

    // Start is called before the first frame update
    void Start()
    {
        if (fishingPole == null)
            fishingPole = GameObject.FindGameObjectWithTag("Fishing Pole");
        moneyAmt = GameObject.FindGameObjectWithTag("TriggerCanvas");
        moneyAmt.SetActive(true);
        fishPoleButton = GameObject.FindGameObjectsWithTag("BuyFishPoleButton");
        fishPoleText = GameObject.FindGameObjectsWithTag("FishingPoleEduText");


        foreach (GameObject g in fishPoleButton)
        {
            g.SetActive(true);
        }
        foreach (GameObject g in fishPoleText)
        {
            g.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayFishPoleEdu()
    {
        foreach (GameObject g in fishPoleButton)
        {
            g.SetActive(false);
        }
        foreach (GameObject g in fishPoleText)
        {
            g.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (this.gameObject.tag == "Fishing Pole")
        {            
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
