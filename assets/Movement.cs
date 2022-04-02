using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movement;
    [SerializeField] const int moveSpeed = 4;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] bool isFacingRight = true;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite idle;
    [SerializeField] Sprite walk1;
    [SerializeField] Sprite walk2;

    // Start is called before the first frame update
    void Start()
    {
        if(rigid == null)
        {
            rigid = GetComponent<Rigidbody2D>();
        }
        spriteRenderer.sprite = idle;
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
            WalkAnimation1();
            Wait();
            WalkAnimation2();
        }
        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
            Flip();
        if (movement == 0.0f)
            spriteRenderer.sprite = idle;

    }
    void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }
    /*public void WalkAnimation1()
    {
        spriteRenderer.sprite = walk1;

    }
    public void WalkAnimation2()
    {
        spriteRenderer.sprite = walk2;
    }*/
    

}
