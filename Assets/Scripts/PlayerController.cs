using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    public Rigidbody rb;
    public Transform egg;
    public Transform eggStart;

    public float speed = 5f;
    public int force = 6;
    public bool Inverted = false;

    private bool isPlaying = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (!isPlaying)
        {
            egg.position = eggStart.position;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                egg.GetComponent<BallMovement>().Launch(force);
                isPlaying = true;
            }
        }

        rb.velocity = (Inverted ? Vector3.left :Vector3.right) * Input.GetAxisRaw("Horizontal") * speed;
    }

    public void SetIsPlaying(bool val)
    {
        isPlaying = val;
    }
}
