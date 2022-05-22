using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FishKeeper : MonoBehaviour
{
    [SerializeField] int smallFishAmt;
    [SerializeField] int largeFishAmt;
    [SerializeField] int mediumFishAmt;
    [SerializeField] int smallFishCaught;
    [SerializeField] int mediumFishCaught;
    [SerializeField] int largeFishCaught;
    [SerializeField] bool nightcrawlers;
    [SerializeField] bool squid;
    [SerializeField] bool mackrel;

    [SerializeField] GameObject moneyKeeper;


    const int FISHING_POLE_SCENE = 4;
    const int CAST_NET_SCENE = 5;
    const int BOAT_SCENE = 6;
    const int SMALL_BAIT_MOD = 2;
    const int MEDIUM_BAIT_MOD = 2;
    const int LARGE_BAIT_MOD = 3;

    int levelNum;
    // Start is called before the first frame update
    void Start()
    {
        smallFishAmt = PersistentData.Instance.GetSmallFish();
        mediumFishAmt = PersistentData.Instance.GetMediumFish();
        largeFishAmt = PersistentData.Instance.GetLargeFish();

        smallFishCaught = 0;
        mediumFishCaught = 0;
        largeFishCaught = 0;
        nightcrawlers = PersistentData.Instance.GetHasNightcrawlers();
        squid = PersistentData.Instance.GetHasSquid();
        mackrel = PersistentData.Instance.GetHasMackrel();
        levelNum = SceneManager.GetActiveScene().buildIndex;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CatchFish()
    {
        if(levelNum == FISHING_POLE_SCENE)
        {
            //RNG values
            smallFishCaught = Random.Range(1,20);
            mediumFishCaught = Random.Range(1,10);
            largeFishAmt = Random.Range(1, 5);

            if (nightcrawlers)
            {
                smallFishCaught = smallFishCaught * SMALL_BAIT_MOD;
            }
            if (squid)
            {
                mediumFishCaught = mediumFishCaught * MEDIUM_BAIT_MOD;
            }
            if (mackrel)
            {
                largeFishAmt = largeFishAmt * LARGE_BAIT_MOD;
            }
            SetFishCaughtLastMonth();

        }
        if(levelNum == CAST_NET_SCENE)
        {
            //RNG values
            smallFishCaught = Random.Range(1, 25);
            mediumFishCaught = Random.Range(1, 15);
            largeFishAmt = Random.Range(1, 2);
            if (nightcrawlers)
            {
                smallFishCaught = smallFishCaught * SMALL_BAIT_MOD;
            }
            if (squid)
            {
                mediumFishCaught = mediumFishCaught * MEDIUM_BAIT_MOD;
            }
            SetFishCaughtLastMonth();
        }
        if(levelNum == BOAT_SCENE)
        {
            //RNG values
            smallFishCaught = Random.Range(1, 10);
            mediumFishCaught = Random.Range(1, 20);
            largeFishCaught = Random.Range(5, 15);

            if (nightcrawlers)
            {
                smallFishCaught = smallFishCaught * SMALL_BAIT_MOD;
            }
            if (squid)
            {
                mediumFishCaught = mediumFishCaught * MEDIUM_BAIT_MOD;
            }
            if (mackrel)
            {
                largeFishAmt = largeFishAmt * LARGE_BAIT_MOD;
            }
            SetFishCaughtLastMonth();
        }


        void SetFishCaughtLastMonth()
        {
            PersistentData.Instance.SetSmallFishCaughtLM(smallFishCaught);
            PersistentData.Instance.SetMediumFishCaughtLM(mediumFishCaught);
            PersistentData.Instance.SetLargeFishCaughtLM(largeFishCaught);
        }
    }
}
