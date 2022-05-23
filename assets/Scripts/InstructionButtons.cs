using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionButtons : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject[] welcomeStory;
    int curMonth;
    bool welcomeDisplayedAlready;
    void Awake()
    {
        welcomeStory = GameObject.FindGameObjectsWithTag("WelcomeStory");
        DisplayWelcomeStory();
    }
    void Start()
    {
        curMonth = PersistentData.Instance.GetMonth();
        welcomeDisplayedAlready = PersistentData.Instance.GetWelcomeStory();
        if(curMonth > 1 || welcomeDisplayedAlready == true)
        {
            RemoveWelcomeStory();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayWelcomeStory()
    {
        foreach(GameObject g in welcomeStory)
        {
            g.SetActive(true);
        }
    }

    void RemoveWelcomeStory()
    {
        foreach (GameObject g in welcomeStory)
        {
            g.SetActive(false);
        }
    }

    public void InstructionOkButton()
    {
        welcomeDisplayedAlready = true;
        PersistentData.Instance.SetWelcomeStory(welcomeDisplayedAlready);
        RemoveWelcomeStory();
    }
}
