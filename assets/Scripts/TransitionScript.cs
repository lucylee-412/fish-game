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
    [SerializeField] TMP_Text criminalActivity;
    [SerializeField] TMP_Text upkeepCosts;
    [SerializeField] TMP_Text fineAmount;
    [SerializeField] TMP_Text totalMoneyMade;
    [SerializeField] int smallFishCaughtAmt;
    [SerializeField] int mediumFishCaughtAmt;
    [SerializeField] int largeFishCaughtAmt;
    [SerializeField] int moneyAmt;
    [SerializeField] int upkeepAmt;
    [SerializeField] int fineAmt;
    [SerializeField] int totalProfit;
    [SerializeField] bool wasPlayerCriminal;
    int curMonth;


    const int BASE_UPKEEP_COST = 100;
    const int BASE_FP_COSTS = 50;
    const int BASE_CN_COSTS = 50;
    const int BASE_BOAT_COSTS = 800;

    //THIS MAY CHANGE DOWN THE ROAD BASED ON THE EVENT TYPE
    const int FINE_AMOUNT = 2500;
    // Start is called before the first frame update
    void Start()
    {
        smallFishCaughtAmt = PersistentData.Instance.GetSmallFishCaughtLM();
        mediumFishCaughtAmt = PersistentData.Instance.GetMediumFishCaughtLM();
        largeFishCaughtAmt = PersistentData.Instance.GetLargeFishCaughtLM();
        moneyAmt = PersistentData.Instance.GetMoneyMadeLastMonth();
        wasPlayerCriminal = PersistentData.Instance.GetCriminalActivity();
        curMonth = PersistentData.Instance.GetMonth();

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

        if(wasPlayerCriminal == true)
        {
            criminalActivity.text = "Criminal Activity: Yes";
        }
        else
        {
            criminalActivity.text = "Criminal Activity: No";
        }
        upkeepCosts.text = "Upkeep Costs: " + GetUpkeepAmt();
        fineAmount.text = "Fine Amount: " + GetFineAmount();
        totalMoneyMade.text = "Total Profit: " + GetTotalProfit();
    }

    int GetUpkeepAmt()
    {
        upkeepAmt = BASE_UPKEEP_COST;
        if(PersistentData.Instance.GetHasFishingPole() == true)
        {
            upkeepAmt += BASE_FP_COSTS;
        }
        if (PersistentData.Instance.GetHasCastNet() == true)
        {
            upkeepAmt += BASE_CN_COSTS;
        }
        if (PersistentData.Instance.GetHasFishingBoat() == true)
        {
            upkeepAmt += BASE_BOAT_COSTS;
        }

        return upkeepAmt;
    }
    int GetFineAmount()
    {
        if(PersistentData.Instance.GetCriminalActivity() == true)
        {
            if(Random.Range(1,3) == 1)
            {
                fineAmt = FINE_AMOUNT;
            }
        }
        else
        {
            fineAmt = 0;
        }

        return fineAmt;
    }

    int GetTotalProfit()
    {
        totalProfit = (moneyAmt - upkeepAmt - fineAmt);
        return totalProfit;
    }
    public void AdvanceTime()
    {
        if (curMonth < 12)
        {
            PersistentData.Instance.AddProfitTransitonScene(totalProfit);
            //increment month
            PersistentData.Instance.SetMonth(curMonth + 1);
            //Reset criminal activity flag to false
            PersistentData.Instance.SetCriminalActivity(false);
            SceneManager.LoadScene("Land&Pier");
        }
        else
        {
            SceneManager.LoadScene("HighScores");
        }
    }

}
