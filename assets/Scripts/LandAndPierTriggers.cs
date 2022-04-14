using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LandAndPierTriggers : MonoBehaviour
{
    [SerializeField] GameObject storeDoor;
    [SerializeField] GameObject player;
    [SerializeField] GameObject fishingSpot;
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite fishingSprite;
    [SerializeField] Sprite walkingSprite;
    // Start is called before the first frame update
    void Start()
    {
        if (storeDoor == null)
            storeDoor = GameObject.FindGameObjectWithTag("StoreDoor");
        if (fishingSpot == null)
            fishingSpot = GameObject.FindGameObjectWithTag("PierFishingSpot");
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");
        spriteRenderer = player.GetComponent<SpriteRenderer>();
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
            SceneManager.LoadScene("Fishing Scene");
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        
        
    }
}
