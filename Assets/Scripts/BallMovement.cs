
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }else
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        }
    }

    void FixedUpdate()
    {
        //rb.AddForce(new Vector2(60.0f, 35.0f));
        //rb.velocity = new Vector2(20.0f, 6.0f);
        
    }
}