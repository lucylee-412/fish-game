using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishQTE : MonoBehaviour
{
    public float fillAmount = 0;
    public float timeThreshold = 0;
    
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            fillAmount+= .2f;
        }
        timeThreshold += Time.deltaTime;

        if (timeThreshold> .1)
        {
            timeThreshold = 0;
            fillAmount -= .02f;
        }

        GetComponent<Image>().fillAmount = fillAmount;
    }
}