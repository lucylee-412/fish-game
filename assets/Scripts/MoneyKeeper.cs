using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MoneyKeeper : MonoBehaviour
{
    [SerializeField] int currentMoney;
    //[SerializeField] Text moneyTxt;
    [SerializeField] string currentName;
    [SerializeField] int curMonth;
    [SerializeField] TMP_Text nameTxt;
    [SerializeField] TMP_Text moneyTxt;
    [SerializeField] TMP_Text monthTxt;
    int levelNum;

    //[SerializeField] Text nameTxt;
    // Start is called before the first frame update
    void Start()
    {
        currentMoney = PersistentData.Instance.GetMoney();
        curMonth = PersistentData.Instance.GetMonth();
        currentName = PersistentData.Instance.GetName();
        moneyTxt.text = "Money: $" + currentMoney;
        nameTxt.text = "Player: " + currentName;
        monthTxt.text = "Month: " + curMonth;
        levelNum = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if(levelNum == 2 || levelNum == 3)
        {
            CheckPlayerMoney();
        }
        
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

    void CheckPlayerMoney()
    {
        if(currentMoney < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
