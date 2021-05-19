using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.left * Input.GetAxisRaw("Horizontal") * speed;
    }
}
