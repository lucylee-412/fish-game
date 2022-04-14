using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    [SerializeField] InputField playerNameInput;
    Equipment fishPoleTest;
    // Start is called before the first frame update
    void Start()
    {
        if (fishPoleTest == null)
            fishPoleTest = GameObject.Find("Fishing Pole").GetComponent<Equipment>();
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
        string s = playerNameInput.text;
        PersistentData.Instance.SetName(s);
        SceneManager.LoadScene("Land&Pier");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BuyFishingPoleButton()
    {
        PersistentData.Instance.SubtractMoney(fishPoleTest.GetFishPoleCost());
    }
}
