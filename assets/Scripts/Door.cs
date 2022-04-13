using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LandAndPierLocations : MonoBehaviour
{
    [SerializeField] GameObject storeDoor;
    // Start is called before the first frame update
    void Start()
    {
        if (storeDoor == null)
            storeDoor = GameObject.FindGameObjectWithTag("StoreDoor");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (this.gameObject.tag == "StoreDoor")
        {
            SceneManager.LoadScene("Bait&Tackle Shop");
        }

        if (this.gameObject.tag == "PierFishingSpot")
        {
            Debug.Log("This is the fishing spot");
        }
    }
}
