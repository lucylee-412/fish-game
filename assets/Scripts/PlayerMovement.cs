using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movement;
    [SerializeField] const int moveSpeed = 4;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] bool isFacingRight = true;
    [SerializeField] int levelNum;


    // Start is called before the first frame update
    void Start()
    {
        if(rigid == null)
        {
            rigid = GetComponent<Rigidbody2D>();
        }
        levelNum = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");

    }

    void FixedUpdate()
    {
        if(levelNum > 0 && levelNum < 4)
        {
            PlayerMove();
        }
        else if (levelNum == 6)
        {
            BoatMovement();
        }

    }
    void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

    public void PlayerMove()
    {
        rigid.velocity = new Vector2(movement * moveSpeed, rigid.velocity.y);

        if (movement > 0 || movement < 0)
        {
            GetComponent<Animator>().SetBool("walking", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("walking", false);
        }

        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
        {
            Flip();
        }
    }

    public void BoatMovement()
    {
        rigid.velocity = new Vector2(movement * moveSpeed, rigid.velocity.y);
        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
        {
            Flip();
        }
    }

    

}
