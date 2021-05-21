using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityUtils.alpha.delegates;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int Score { get; private set; } = 0;
    public int Lives { get; private set; } = 3;

    public GameObject[] bricks;
    public EventDelegates.CommonHandle OnGameOver;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (Lives <= 0)
        {
            if (OnGameOver != null)
                OnGameOver?.Invoke();
        }
    }
}
