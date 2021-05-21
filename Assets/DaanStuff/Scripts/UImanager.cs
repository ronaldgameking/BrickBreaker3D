using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    private void Start()
    {
        AddScore(0);
    }

    public void AddScore(int amount)
    {
        GameManager.Instance.Score = GameManager.Instance.Score + amount;
        scoreText.text = "" + GameManager.Instance.Score;
    }
}
