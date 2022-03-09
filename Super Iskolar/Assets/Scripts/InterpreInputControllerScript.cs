using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpreInputControllerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sp;
    public Sprite left,right;
    private float moveSpeed, jumpForce;
    private bool moveLeft, moveRight,moveDash, iskolarDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp= GetComponent<SpriteRenderer>();
        moveSpeed = 5f;
        jumpForce = 500f;
        moveLeft = false;
        moveRight = false;
        moveDash = false;
        iskolarDirection = false; // facing right
    }

    public void MoveLeft(){
        if(!iskolarDirection){ // if facing right, rotate
            transform.Rotate(0f, 180f, 0f); // rotate character orientation on x-axis
        }
        moveLeft = true;
        iskolarDirection = true;
    }
    public void MoveRight(){
        if(iskolarDirection){ // if facing left, rotate
            transform.Rotate(0f, 180f, 0f); // rotate character orientation on x-axis
        }
        moveRight = true;
        iskolarDirection = false;
    }
    public void Jump(){
        if (rb.velocity.y ==0){
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
    public void StopMoving(){
        moveLeft = false;
        moveRight = false;
        moveDash = false;
        rb.velocity = Vector2.zero;
    }
    public void Dash(){
        moveDash = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(moveLeft){
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
        if(moveRight){
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        if(moveDash){
            if(iskolarDirection){
                rb.velocity = new Vector2(-3*moveSpeed, rb.velocity.y);
            }else{
                rb.velocity = new Vector2(3*moveSpeed, rb.velocity.y);
            }
        }
        if(iskolarDirection){
            sp.sprite = left;
        }else{
            sp.sprite = right;
        }
    }
}
