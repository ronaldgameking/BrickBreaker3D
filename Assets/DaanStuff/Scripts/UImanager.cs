using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private float score;

    private void Start()
    {
        AddScore(0);
    }

    public void AddScore(float amount)
    {
        score = score + amount;
        scoreText.text = "" + score;
    }
}
