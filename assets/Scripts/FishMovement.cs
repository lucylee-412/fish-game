using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishMovement : MonoBehaviour
{
    public float fishUpBound;
    public float fishDownBound;
    public float fishLeftBound;
    public float fishRightBound;
    [SerializeField] float movement;
    const int moveSpeed = 1;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] bool isFacingRight = true;

    float movementUD;
    bool waitPeriodOver;
    int levelNum;
    int waitTime;
    // Start is called before the first frame update
    void Start()
    {
        levelNum = SceneManager.GetActiveScene().buildIndex;
        if(levelNum == 4 || levelNum  == 5)
        {
            fishUpBound = -3.355f;
            fishDownBound = -4.725f;
            fishLeftBound = -3.530f;
            fishRightBound = 9.5f;
        }
        else if (levelNum == 6)
        {
            fishUpBound = -1.376f;
            fishDownBound = -4.734f;
            fishLeftBound = -9.0f;
            fishRightBound = 9.0f;
        }
        if (rigid == null)
        {
            rigid = GetComponent<Rigidbody2D>();
        }
        movement = .1f;
        waitPeriodOver = true;
    }

    // Update is called once per frame
    void Update()
    {
        CheckBoundsOfWater();
        rigid.velocity = new Vector2(movement * moveSpeed, rigid.velocity.y);
        fishMovement();
        //rigid.velocity = new Vector2(movement * moveSpeed, movementUD * moveSpeed);

    }

    public void fishMovement()
    {
        if (waitPeriodOver)
        {
            StartCoroutine(fishWaitToMove());
        }
        //rigid.velocity = new Vector2(movement * moveSpeed, rigid.velocity.y);
        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
        {
            Flip();
        }
    }

    IEnumerator fishWaitToMove()
    {
        waitPeriodOver = false;
        waitTime = Random.Range(3, 6);
        movement = Random.Range(-0.3f, 0.4f);
        //movementUD = Random.Range(-0.3f, 0.4f);
        yield return new WaitForSeconds(waitTime);
        waitPeriodOver = true;
        movement = 0;
    }

    void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

    void CheckBoundsOfWater()
    {
        if (rigid.transform.position.x < fishLeftBound && movement < 0)
        {
            if (!isFacingRight)
            {
                Flip();
                movement = -movement;
            }
            else
                movement = -movement;
        }
        else if (rigid.transform.position.x > fishRightBound && movement > 0)
        {
            if (isFacingRight)
            {
                Flip();
                movement = -movement;
            }
            else
                movement = -movement;
        }
    }
}
