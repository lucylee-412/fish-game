using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyKeeper : MonoBehaviour
{
    [SerializeField] int money;
    [SerializeField] Text moneyTxt;
    [SerializeField] Text nameTxt;
    // Start is called before the first frame update
    void Start()
    {
        money = PersistentData.Instance.GetMoney();
        DisplayMoney();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayMoney()
    {
        moneyTxt.text = "Money: $" + money;
    }
    public void DisplayName()
    {
        nameTxt.text = "Hi, " + PersistentData.Instance.GetName();
    }
    public void AddMoney(int m)
    {
        money += m;
        DisplayMoney();
        PersistentData.Instance.SetMoney(money);
    }
    public void SubtractMoney(int m)
    {
        money -= m;
        DisplayMoney();
        PersistentData.Instance.SetMoney(money);
    }
}
