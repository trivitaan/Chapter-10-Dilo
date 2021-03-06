
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement_Prob4 : MonoBehaviour
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
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
            
    }

    void FixedUpdate()
    {
        //rb.AddForce(new Vector2(60.0f, 35.0f));
        //rb.velocity = new Vector2(20.0f, 6.0f);
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}