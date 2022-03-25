using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrol : MonoBehaviour
{
    public float walkSpeed;
    
    [HideInInspector]
    public bool mustPatrol;
    private bool mustTurn;

    public Rigidbody2D rb;
    public Transform groundCheckPos;
    public LayerMask groundLayer;
    public Collider2D bodyCollider;

    void Start()
    {
        // initiate mustPatrol to true
        mustPatrol = true;

    }

    void Update()
    {
        // while patrol value is true, call Patrol() function
        if(mustPatrol)
        {
            Patrol();
        }
    }

    private void FixedUpdate()
    {
        if(mustPatrol)
        {
            // return true if detects collision / ground
            mustTurn = !Physics2D.OverlapCircle(groundCheckPos.position, 0.3f, groundLayer);
        }
    }

    void Patrol()
    {
        if(mustTurn || bodyCollider.IsTouchingLayers(groundLayer))
        {
            Flip();
        }
        
        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    // flip enemy walk direction; flips left or right
    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y); // flips enemy orientation; can comment out?
        walkSpeed *= -1;
        mustPatrol = true;
    }
}
