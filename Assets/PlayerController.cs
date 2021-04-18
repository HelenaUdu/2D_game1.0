using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public float jumpForce;

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput*moveSpeed, rb.velocity.y); 
        
    }

    void Update()
    {
        if(isGrounded() && Input.GetKeyDown(KeyCode.UpArrow) || isGrounded() && Input.GetKeyDown("w"))
        {
            rb.AddForce(Vector2.up*jumpForce, ForceMode2D.Force);
        }
    }

    bool isGrounded()
    {
        RaycastHit2D hit=Physics2D.Raycast(transform.position, Vector2.down, 1.0f);
        return hit.collider != null;
    }
}
