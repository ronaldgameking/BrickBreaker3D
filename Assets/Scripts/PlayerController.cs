using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public Transform egg;
    public Transform eggStart;

    public float speed = 5f;
    public int force = 10;
    public bool Inverted = false;

    private bool isPlaying = false;

    void Update()
    {
        if (!isPlaying)
        {
            egg.position = eggStart.position;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                egg.GetComponent<BallSystem>().Launch(force);
                isPlaying = true;
            }
        }

        rb.velocity = (Inverted ? Vector3.left :Vector3.right) * Input.GetAxisRaw("Horizontal") * speed;
    }
}
