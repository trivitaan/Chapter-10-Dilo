
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement_Prob5 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    Vector2 movement;
    Vector2 targetPosition;
    private bool isMoving;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        if(isMoving)
        {
            Vector2 newPos = Vector2.MoveTowards(transform.position, targetPosition, speed*Time.fixedDeltaTime);
            rb.MovePosition(newPos);
        }

    }

    void FixedUpdate()
    {
    }

    void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isMoving = true;    
    }
}