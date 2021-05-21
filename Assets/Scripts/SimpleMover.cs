using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMover : MonoBehaviour
{
    public Vector3 direction;
    public Rigidbody rb;
    public float speed = 10;

    private bool move = true;
    private float frameTick = 0;

    private void Update()
    {
        if (move)
        {
            if (frameTick == speed)
            {
                rb.AddForce(direction);
                frameTick = 0;
                return;
            }
            frameTick++;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(transform.position, transform.position + direction * 2);
    }
}
