using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UImanager : MonoBehaviour
{
    public static UImanager Instance { get; private set; }

    public TextMeshProUGUI scoretextTmpro;
    [SerializeField] private Text scoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        GameManager.Instance.OnGameOver += ShowDeathScreen;
        AddScore(0);
    }

    public void AddScore(int amount)
    {
        GameManager.Instance.Score = GameManager.Instance.Score + amount;
        if (scoretextTmpro != null)
        {
            scoretextTmpro.text = GameManager.Instance.Score.ToString();

        }
        else
        {
            scoreText.text = "" + GameManager.Instance.Score;
        }
    }

    public void ShowDeathScreen()
    {

    }
}
