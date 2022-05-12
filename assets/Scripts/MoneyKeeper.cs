using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyKeeper : MonoBehaviour
{
    [SerializeField] int currentMoney;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 5aa05395114d8c3a62880c55593572dfec04b1b6
    [SerializeField] Text moneyTxt;
    [SerializeField] string currentName;
    [SerializeField] Text nameTxt;
    
<<<<<<< HEAD
=======
=======
>>>>>>> 5aa05395114d8c3a62880c55593572dfec04b1b6
    [SerializeField] int curMonth;
    [SerializeField] TMP_Text moneyTxt;
    [SerializeField] TMP_Text monthTxt;

    //[SerializeField] Text nameTxt;
<<<<<<< HEAD
>>>>>>> main
=======
>>>>>>> 5aa05395114d8c3a62880c55593572dfec04b1b6
    // Start is called before the first frame update
    void Start()
    {
        currentMoney = PersistentData.Instance.GetMoney();
        curMonth = PersistentData.Instance.GetMonth();
<<<<<<< HEAD
        moneyTxt.text = "Money: $" + currentMoney;
<<<<<<< HEAD
        currentName = PersistentData.Instance.GetName();
        nameTxt.text = "Player: " + currentName;
=======
        monthTxt.text = "Month: " + curMonth;
>>>>>>> main
=======
        moneyTxt.text = "Money: $" + currentMoney();
        currentName = PersistentData.Instance.GetName();
        nameTxt.text = "Player: " + currentName;
        monthTxt.text = "Month: " + curMonth;
>>>>>>> 5aa05395114d8c3a62880c55593572dfec04b1b6
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
