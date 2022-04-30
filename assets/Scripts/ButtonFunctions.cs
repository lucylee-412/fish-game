using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    [SerializeField] GameObject moneyKeeper;
    //[SerializeField] InputField playerNameInput;
    //[SerializeField] int money;

    // Start is called before the first frame update
    void Start()
    {
        if(moneyKeeper == null)
        {
            moneyKeeper = GameObject.FindGameObjectWithTag("GameController");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Land&Pier");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BuyFishingPoleButton()
    {
        moneyKeeper.GetComponent<MoneyKeeper>().SubtractMoney(500);
        
    }

}
