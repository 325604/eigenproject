using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody playerRb;
    private float zBound = 10;
    private float xBound = 16f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveplayer();
        ConstrainPlayer();
    }

    void moveplayer()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * VerticalInput);
        playerRb.AddForce(Vector3.right * speed * HorizontalInput);

    }
//hier staat de positie van de gebieden waar je in blijft
    void ConstrainPlayer()
    {
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }

        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
    }
}

