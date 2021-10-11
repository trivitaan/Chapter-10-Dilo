
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement_Prob2 : MonoBehaviour
{   
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(20.0f, 6.0f);
    }

}