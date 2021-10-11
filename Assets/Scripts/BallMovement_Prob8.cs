
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement_Prob8 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    Vector2 movement;
    public float respawnTime;
    
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
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

}