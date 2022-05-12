using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyKeeper : MonoBehaviour
{
    [SerializeField] int currentMoney;
<<<<<<< HEAD
    [SerializeField] Text moneyTxt;
    [SerializeField] string currentName;
    [SerializeField] Text nameTxt;
    
=======
    [SerializeField] int curMonth;
    [SerializeField] TMP_Text moneyTxt;
    [SerializeField] TMP_Text monthTxt;

    //[SerializeField] Text nameTxt;
>>>>>>> main
    // Start is called before the first frame update
    void Start()
    {
        currentMoney = PersistentData.Instance.GetMoney();
        curMonth = PersistentData.Instance.GetMonth();
        moneyTxt.text = "Money: $" + currentMoney;
<<<<<<< HEAD
        currentName = PersistentData.Instance.GetName();
        nameTxt.text = "Player: " + currentName;
=======
        monthTxt.text = "Month: " + curMonth;
>>>>>>> main
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateMoneyDisplay()
    {
        moneyTxt.text = "Money: $" + PersistentData.Instance.GetMoney();
    }
    
    public void DisplayName()
    {
        nameTxt.text = "Player: " + PersistentData.Instance.GetName();
    }
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
