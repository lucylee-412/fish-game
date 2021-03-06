using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MoneyKeeper : MonoBehaviour
{
    [SerializeField] GameObject shopkeeper;
    [SerializeField] int currentMoney;
    [SerializeField] string currentName;
    [SerializeField] int curMonth;
    [SerializeField] TMP_Text nameTxt;
    [SerializeField] TMP_Text moneyTxt;
    [SerializeField] TMP_Text monthTxt;
    int levelNum;

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
        Debug.Log(levelNum);
        if(levelNum == 2)
        {
            shopkeeper = GameObject.FindGameObjectWithTag("SpeechController");
        }
    }

    // Check done when player loads into land or shop* scenes (precaution)
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
    // If this transaction won't break the bank, allow player to buy item
    public void SubtractMoney(int m)
    {
        if (currentMoney - m >= 0) 
        {
            currentMoney -= m;
            PersistentData.Instance.SetMoney(currentMoney);
            UpdateMoneyDisplay();
        }
    }

    public bool checkIfPlayerHasEnoughMoney(int val)
    {
        int enoughMoney = currentMoney - val;
        if(enoughMoney >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Check done at start of new level
    void CheckPlayerMoney()
    {
        if(currentMoney < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
