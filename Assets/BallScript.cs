using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(0, -1);

    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = rb.velocity.normalized * 8;

        if (rb.velocity.y == 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, -1);
        }

    }
}
