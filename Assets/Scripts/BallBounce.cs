using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Wall"))
        {
            Debug.LogWarning(Vector3.Reflect(Vector3.up, collision.transform.position));
        }    
    }
}
