using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LandAndPierTriggers : MonoBehaviour
{
    [SerializeField] GameObject storeDoor;
    [SerializeField] GameObject player;
    [SerializeField] GameObject fishingSpot;
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite fishingSprite;
    [SerializeField] Sprite walkingSprite;
    [SerializeField] bool hasFishPole;
    [SerializeField] bool hasCastNet;
    [SerializeField] bool hasBoat;

    [SerializeField] GameObject goFishWithPoleButton;
    [SerializeField] GameObject goFishWithNetButton;
    [SerializeField] GameObject goFishWithBoatButton;
    [SerializeField] GameObject fishingQuestion;
    [SerializeField] GameObject noEquipmentText;



    private void Awake()
    {
        goFishWithBoatButton = GameObject.FindGameObjectWithTag("GoBoatButton");
        goFishWithNetButton = GameObject.FindGameObjectWithTag("GoCastNetButton");
        goFishWithPoleButton = GameObject.FindGameObjectWithTag("GoFishPoleButton");
        fishingQuestion = GameObject.FindGameObjectWithTag("FishingQuestion");
        noEquipmentText = GameObject.FindGameObjectWithTag("NoEquipmentText");

        //used to ensure canvas is used at least once to make sure it can be turned active or inactive
        goFishWithPoleButton.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (storeDoor == null)
            storeDoor = GameObject.FindGameObjectWithTag("StoreDoor");
        if (fishingSpot == null)
            fishingSpot = GameObject.FindGameObjectWithTag("PierFishingSpot");
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");
        hasFishPole = PersistentData.Instance.GetHasFishingPole();
        hasCastNet = PersistentData.Instance.GetHasCastNet();
        hasBoat = PersistentData.Instance.GetHasFishingBoat();

        spriteRenderer = player.GetComponent<SpriteRenderer>();

        SetAllButtonsFalse();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (this.gameObject.tag == "StoreDoor")
        {
            SceneManager.LoadScene("Bait&TackleShop");
        }

        if (this.gameObject.tag == "PierFishingSpot")
        {
            fishingQuestion.SetActive(true);
            if (hasFishPole == true)
                goFishWithPoleButton.SetActive(true);
            if(hasCastNet == true)
                goFishWithNetButton.SetActive(true);
            if(hasBoat == true)
                goFishWithBoatButton.SetActive (true);
            if(hasFishPole == false && hasCastNet == false && hasBoat == false)
            {
                noEquipmentText.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        SetAllButtonsFalse();
        
    }

    public void SetAllButtonsFalse()
    {
        goFishWithPoleButton.SetActive(false);
        goFishWithNetButton.SetActive(false);
        goFishWithBoatButton.SetActive(false);
        fishingQuestion.SetActive(false);
        noEquipmentText.SetActive(false);
    }
}
