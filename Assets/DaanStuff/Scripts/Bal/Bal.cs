using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bal : MonoBehaviour
{
    private UImanager uImanager;
    void Start()
    {
        uImanager = FindObjectOfType<UImanager>();
        uImanager.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            uImanager.AddScore(200);
            Destroy(collision.gameObject);
        }
    }
}
