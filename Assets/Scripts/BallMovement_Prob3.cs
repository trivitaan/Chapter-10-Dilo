
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement_Prob3 : MonoBehaviour
{   
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(10.0f, 6.0f));
    }

}