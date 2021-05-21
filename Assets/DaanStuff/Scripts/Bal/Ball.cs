using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {
        if (UImanager.Instance != null) UImanager.Instance.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            if (UImanager.Instance != null) UImanager.Instance.AddScore(200);
            GameManager.Instance.bricksLeft--;
            GameManager.Instance.CheckIfDone();
            Destroy(collision.gameObject);
        }
    }
}
