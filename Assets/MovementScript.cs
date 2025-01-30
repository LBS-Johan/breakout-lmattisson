using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementScript : MonoBehaviour

{
    //Define Variables
    float mouseX = 0;
    float oldMouseX = 0;

    public float divide;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {

        mouseX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;

        float differance = mouseX - oldMouseX;

        transform.position = new Vector3(mouseX, transform.position.y, transform.position.z);

        if (differance > 0)
        {

            float rotation = Mathf.Lerp(0, 15, differance / divide);

            transform.rotation = Quaternion.Euler(0, 0, -rotation);

        }

        else if (differance < 0)
        {

            float rotation = Mathf.Lerp(0, 15, -differance / divide);

            transform.rotation = Quaternion.Euler(0, 0, rotation);

        }

        else
        {

            transform.rotation = Quaternion.Euler(0, 0, 0);

        }

        oldMouseX = mouseX;




    }
}
