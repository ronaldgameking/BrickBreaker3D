using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.bricksLeft++;
        Destroy(this);
    }
}
