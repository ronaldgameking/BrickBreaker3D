using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSystem : MonoBehaviour
{
    public Rigidbody rb;

    [Tooltip("Is physics done by another script?")]
    public bool managedColliding = false;

    private void Awake()
    {
        if (!managedColliding) rb.drag = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathBarrier"))
        {
            GameManager.Instance.Lives--;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Wall") && !managedColliding)
        {
            Debug.Log("Reflected");
            rb.velocity = Vector3.zero;
            SimpleMover sm = GetComponent<SimpleMover>();
            sm.direction = new Vector3(
                Mathf.Clamp(Vector3.Reflect(sm.direction, collision.transform.position).x, -1f, 1f), 
                Mathf.Clamp(Vector3.Reflect(sm.direction, collision.transform.position).y, -1f, 1f), 
                Mathf.Clamp(Vector3.Reflect(sm.direction, collision.transform.position).z, -1f, 1f));
        }
    }

    public void Launch(float force)
    {
        rb.AddForce(Vector3.forward * force);
    }
}
