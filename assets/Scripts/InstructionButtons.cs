using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionButtons : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject[] welcomeStory;
    [SerializeField] GameObject welcomeCanvas;
    int curMonth;
    bool welcomeDisplayedAlready;
    void Awake()
    {
        if (welcomeStory == null)
        {
            welcomeStory = GameObject.FindGameObjectsWithTag("WelcomeStory");
        }
        foreach(GameObject g in welcomeStory)
        {
            g.SetActive(true);
        }
    }
    void Start()
    {
        welcomeCanvas = GameObject.FindGameObjectWithTag("WelcomeCanvas");
        welcomeCanvas.SetActive(true);
        curMonth = PersistentData.Instance.GetMonth();
        welcomeDisplayedAlready = PersistentData.Instance.GetWelcomeStory();
        foreach(GameObject g in welcomeStory)
        {
            g.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(curMonth == 1 && welcomeDisplayedAlready == false)
        {
            DisplayWelcomeStory();
        }
    }

    public void DisplayWelcomeStory()
    {
        foreach(GameObject g in welcomeStory)
        {
            g.SetActive(true);
        }
    }

    public void InstructionOkButton()
    {
        PersistentData.Instance.SetWelcomeStory(true);
        welcomeCanvas.SetActive(false);
    }
}
