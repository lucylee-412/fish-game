using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FishHealth : MonoBehaviour
{
    [SerializeField] TMP_Text smallFishHealth;
    [SerializeField] TMP_Text mediumFishHealth;
    [SerializeField] TMP_Text largeFishHealth;
    float smallFishPercentage;
    float mediumFishPercentage;
    float largeFishPercentage;

    // Start is called before the first frame update
    void Start()
    {
        smallFishPercentage = PersistentData.Instance.GetCurrentSmallFishPercentage() * 100;
        mediumFishPercentage = PersistentData.Instance.GetCurrentMedFishPercentage() * 100;
        largeFishPercentage = PersistentData.Instance.GetCurrentLargeFishPercentage() * 100;
        DisplayFishHealth();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DisplayFishHealth()
    {
        smallFishHealth.text = "Small Fish Health: " + smallFishPercentage.ToString() + "%";
        mediumFishHealth.text = "Medium Fish Health: " + mediumFishPercentage.ToString() + "%";
        largeFishHealth.text = "Large Fish Health: " + largeFishPercentage.ToString() + "%";
    }
}
