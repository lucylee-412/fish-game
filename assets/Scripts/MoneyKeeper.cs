using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyKeeper : MonoBehaviour
{
    [SerializeField] int currentMoney;
    [SerializeField] Text moneyTxt;

    //[SerializeField] Text nameTxt;
    // Start is called before the first frame update
    void Start()
    {
        currentMoney = PersistentData.Instance.GetMoney();
        moneyTxt.text = "Money: $" + currentMoney;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateMoneyDisplay()
    {
        moneyTxt.text = "Money: $" + PersistentData.Instance.GetMoney();
    }
    /*
    public void DisplayName()
    {
        nameTxt.text = "Hi, " + PersistentData.Instance.GetName();
    }*/
    public void AddMoney(int m)
    {
        currentMoney += m;
        PersistentData.Instance.SetMoney(currentMoney);
        UpdateMoneyDisplay();
    }
    public void SubtractMoney(int m)
    {
        if (currentMoney - m >= 0)
        {
            currentMoney -= m;
            PersistentData.Instance.SetMoney(currentMoney);
            UpdateMoneyDisplay();
        }
        else
        {
            Debug.Log("Not enough Money!");
        }
    }
}