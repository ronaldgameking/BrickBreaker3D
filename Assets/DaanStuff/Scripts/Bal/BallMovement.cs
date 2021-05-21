using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int speed;
    public int rotation;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        speed = 6;
        rotation = 6;
    }

    private void Update()
    {
        rb.velocity = new Vector3(rotation, rb.velocity.y, speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            speed = 6;
        }

        if (collision.gameObject.CompareTag("Brick"))
        {
            speed = 6;
        }
        if (collision.gameObject.CompareTag("LeftWall"))
        {
            Debug.Log("contact with leftwall");
            rotation = 6;
        }
        if (collision.gameObject.CompareTag("RightWall"))
        {
            Debug.Log("contact with rightwall");
            rotation = -6;
        }
        if (collision.gameObject.CompareTag("BackWall"))
        {
            speed = -6;
        }
    }
}

