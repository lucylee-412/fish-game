using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movement;
    [SerializeField] const int moveSpeed = 4;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] bool isFacingRight = true;


    // Start is called before the first frame update
    void Start()
    {
        if(rigid == null)
        {
            rigid = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");

    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(movement * moveSpeed, rigid.velocity.y);
        if(movement > 0 || movement < 0)
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
    void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

    

}
