using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneyWarning : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject[] moneyWarning;
    int curMoney;
    int curMonth;
    bool moneyWarningDisplayed;

    const int MONEY_WARNING_THRESHOLD = 1500;

    void Awake()
    {
        moneyWarning = GameObject.FindGameObjectsWithTag("MoneyWarning");
        DisplayMoneyWarning();
    }
    void Start()
    {
        curMonth = PersistentData.Instance.GetMonth();
        curMoney = PersistentData.Instance.GetMoney();
        moneyWarningDisplayed = false;
        //RemoveMoneyWarning();

        if (curMonth > 1 && curMoney < MONEY_WARNING_THRESHOLD && moneyWarningDisplayed == false)
        {
            DisplayMoneyWarning();
        }
        else
        {
            RemoveMoneyWarning();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DisplayMoneyWarning()
    {
        foreach (GameObject g in moneyWarning)
        {
            g.SetActive(true);
        }
    }

    void RemoveMoneyWarning()
    {
        foreach (GameObject g in moneyWarning)
        {
            g.SetActive(false);
        }
    }

    public void MoneyWarningOkButton()
    {
        moneyWarningDisplayed = true;
        RemoveMoneyWarning();
    }
}
