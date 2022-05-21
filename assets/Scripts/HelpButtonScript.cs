using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpButtonScript : MonoBehaviour
{
    [SerializeField] GameObject[] helpPanel;
    // Start is called before the first frame update

    void Awake()
    {
        helpPanel = GameObject.FindGameObjectsWithTag("HelpPanel");
        DisplayHelp();
    }
    void Start()
    {
        HelpScreenOk();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisplayHelp()
    {
        foreach (GameObject g in helpPanel)
        {
            g.SetActive(true);
        }
    }
    public void HelpScreenOk()
    {
        foreach (GameObject g in helpPanel)
        {
            g.SetActive(false);
        }
    }
}
