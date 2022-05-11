using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    [SerializeField] TMP_Text smallFishCaught;
    [SerializeField] TMP_Text mediumFishCaught;
    [SerializeField] TMP_Text largeFishCaught;
    [SerializeField] TMP_Text moneyMade;
    [SerializeField] int smallFishCaughtAmt;
    [SerializeField] int mediumFishCaughtAmt;
    [SerializeField] int largeFishCaughtAmt;
    [SerializeField] int moneyAmt;
    // Start is called before the first frame update
    void Start()
    {
        smallFishCaughtAmt = PersistentData.Instance.GetSmallFishCaughtLM();
        mediumFishCaughtAmt = PersistentData.Instance.GetMediumFishCaughtLM();
        largeFishCaughtAmt = PersistentData.Instance.GetLargeFishCaughtLM();
        moneyAmt = PersistentData.Instance.GetMoneyMadeLastMonth();

        DisplayInformation();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DisplayInformation()
    {
        smallFishCaught.text = "Small Fish Caught: " + smallFishCaughtAmt;
        mediumFishCaught.text = "Medium Fish Caught: " + mediumFishCaughtAmt;
        largeFishCaught.text = "Large Fish Caught: " + largeFishCaughtAmt;
        moneyMade.text = "Money Made From Fishing: $" + moneyAmt;
    }

}
