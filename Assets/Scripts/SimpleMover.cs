using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMover : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 10;
    
    private float frameTick = 0;

    private void Update()
    {
        if (frameTick == speed)
        {

            frameTick = 0;
            return;
        }
        frameTick++;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(transform.position, transform.position + direction * 2);
    }
}
