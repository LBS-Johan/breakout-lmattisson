using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakScript : MonoBehaviour
{
    Vector3 boxPosition = new Vector3();

    private void Start()
    {

        boxPosition = transform.position;

    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        

        Destroy(gameObject);

    }

}
