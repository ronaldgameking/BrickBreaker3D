using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    public static UImanager Instance { get; private set; }

    [SerializeField] private Text scoreText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        GameManager.Instance.OnGameOver += ShowDeathScreen;
        AddScore(0);
    }

    public void AddScore(int amount)
    {
        GameManager.Instance.Score = GameManager.Instance.Score + amount;
        scoreText.text = "" + GameManager.Instance.Score;
    }

    public void ShowDeathScreen()
    {

    }
}
