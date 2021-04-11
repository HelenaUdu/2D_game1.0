using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput*moveSpeed, rb.velocity.y); 
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
