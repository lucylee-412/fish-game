using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopkeeperResponse : MonoBehaviour
{
    [SerializeField] TMP_Text shopKeeperResponse;
    [SerializeField] GameObject shopkeepSpeechBubble;
    [SerializeField] bool hasItem;
    [SerializeField] bool notEnoughMoney;

    // Start is called before the first frame update
    void Start()
    {
        shopkeepSpeechBubble = GameObject.FindGameObjectWithTag("SpeechBubble");
        hasItem = false;
        notEnoughMoney = false;
        shopkeepSpeechBubble.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(hasItem == true || notEnoughMoney == true)
        {
            shopkeepSpeechBubble.SetActive(true);
            DisplaySpeechBubble();
            StartCoroutine(SpeechBubbleTimeout());
        }
    }

    public void setNotEnoughMoney(bool val)
    {
        notEnoughMoney = val;
    }
    public void setHasItem(bool val)
    {
        hasItem = val;
    }

    void DisplaySpeechBubble()
    {
        if (hasItem)
        {
            shopKeeperResponse.text = "You already have that item Bub!";
        }
        else if (notEnoughMoney)
        {
            shopKeeperResponse.text = "You don't have enough money bub";
        }
    }

    public void SetSpeechBubbleInactive()
    {
        shopkeepSpeechBubble.SetActive(false);
    }

    IEnumerator SpeechBubbleTimeout()
    {
        yield return new WaitForSeconds(4);
        hasItem = false;
        notEnoughMoney = false;
        shopkeepSpeechBubble.SetActive(false);

    }

}
