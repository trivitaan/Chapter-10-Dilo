<<<<<<< Updated upstream
﻿using System.Collections;
=======
using System.Collections;
>>>>>>> Stashed changes
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
<<<<<<< Updated upstream
    public Transform target;
    public float speed;
=======
    private Rigidbody2D rb;
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        
=======
        rb = GetComponent<Rigidbody2D>();
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void FixedUpdate()
    {
<<<<<<< Updated upstream
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed);
    }
=======
        rb.AddForce(new Vector2(150.0f, 50.0f)*Time.deltaTime);
    }

>>>>>>> Stashed changes
}
