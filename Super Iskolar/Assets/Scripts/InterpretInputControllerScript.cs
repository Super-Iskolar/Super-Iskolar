using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpretInputControllerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sp;
    public Sprite left,right;
    private float moveSpeed, jumpForce, dashForce,dashTime, dashTimeCurrent, dashCoolDown, dashTimer = 0f;
    private bool moveLeft, moveRight,moveDash, isDashing, isGrounded;
    public static bool isIskolarFacingleft;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp= GetComponent<SpriteRenderer>();
        moveSpeed = 6f;
        jumpForce = 500f;
        dashForce = 6f;
        dashTime = 0.15f;            // time period of dashing; counted using dashTimer
        dashCoolDown = 1f;          // time period between dashes; counted using dashTime
        moveLeft = false;
        moveRight = false;
        moveDash = false;
        isIskolarFacingleft = false; // facing right
        isGrounded = false;
    }

    public void MoveLeft(){
        // if(!isIskolarFacingleft){ // if facing right, rotate
        //     transform.Rotate(0f, 180f, 0f); // rotate character orientation on x-axis
        // }
        moveLeft = true;
        isIskolarFacingleft = true;
    }
    public void MoveRight(){
        // if(isIskolarFacingleft){ // if facing left, rotate
        //     transform.Rotate(0f, 180f, 0f); // rotate character orientation on x-axis
        // }
        moveRight = true;
        isIskolarFacingleft = false;
    }
    public void Jump(){
        if (rb.velocity.y ==0 && isGrounded){
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
    public void StopMoving(){
        moveLeft = false;
        moveRight = false;
        rb.velocity = Vector2.zero;
    }
    public void Dash(){
        if(dashTimer<=0){
            moveDash = true;
            dashTimer = dashCoolDown;
            dashTimeCurrent = dashTime;
        }
    }
    // Update is called once per frame
    void Update()
    {   
        if(dashTimer>0){dashTimer -= Time.deltaTime;} // countdown dash time        
        if(moveDash){
            if(isIskolarFacingleft){
                rb.velocity = new Vector2(-dashForce*moveSpeed, 0f);
                dashTimeCurrent -= Time.deltaTime;
                // rb.AddForce(Vector2.left * dashForce);
                // rb.velocity = new Vector2(-3*moveSpeed, rb.velocity.y);
            }else{
                rb.velocity = new Vector2(dashForce*moveSpeed, 0f);
                dashTimeCurrent -= Time.deltaTime;
                // rb.AddForce(Vector2.right * dashForce);
                // rb.velocity = new Vector2(3*moveSpeed, rb.velocity.y);
            }
            if(dashTimeCurrent<0){
                moveDash = false;
                rb.velocity = Vector2.zero;
            }
        }
        else if(moveLeft){
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
        else if(moveRight){
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        if(isIskolarFacingleft){
            sp.sprite = left;
        }else{
            sp.sprite = right;
        }
        
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground" || col.gameObject.tag == "Pencil"){
            isGrounded = true;
        }
    }
    
    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground"){
            isGrounded = false;
        }
    }
}
