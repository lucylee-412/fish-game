using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishSpawner : MonoBehaviour
{
    int levelNum;
    int smallFishNum;
    int mediumFishNum;
    int largeFishNum;

    float xMax;
    float xMin;
    float yMax;
    float yMin;

    [SerializeField] GameObject smallFishPrefab;
    [SerializeField] GameObject mediumFishPrefab;
    [SerializeField] GameObject largeFishPrefab;

    // Start is called before the first frame update
    void Start()
    {
        levelNum = SceneManager.GetActiveScene().buildIndex;

        if(levelNum == 4 || levelNum == 5)
        {
            smallFishNum = 5;
            mediumFishNum = 3;
            largeFishNum = 2;
            xMax = 8.422f;
            xMin = -3.530f;
            yMin = -4.725f;
            yMax = -3.355f;
        }
        else if (levelNum == 6)
        {
            smallFishNum = 10;
            mediumFishNum = 10;
            largeFishNum = 20;
            xMax = 9.5f;
            xMin = -9.5f;
            yMin = -1.376f;
            yMax = -4.734f;
        }
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {

        for (int i = 0; i < smallFishNum; i++)
        {
            Vector2 position = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
            Instantiate(smallFishPrefab, position, Quaternion.identity);
        }
        for (int i = 0; i < mediumFishNum; i++)
        {
            Vector2 position = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
            Instantiate(mediumFishPrefab, position, Quaternion.identity);
        }
        for (int i = 0; i < largeFishNum; i++)
        {
            Vector2 position = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
            Instantiate(largeFishPrefab, position, Quaternion.identity);
        }
    }
}
