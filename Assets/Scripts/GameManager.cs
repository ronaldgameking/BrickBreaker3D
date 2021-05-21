using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityUtils.alpha.delegates;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int Score { get; set; } = 0;
    public int Lives { get; set; } = 1;

    public VideoPlayer vp;
    public GameObject vidProj;
    public GameObject winproj;
    public int videoDelay = -10;
    public int bricksLeft;

    public EventDelegates.CommonHandle OnGameOver;

    bool playerIsDead = false;

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
        OnGameOver += GameOver;
    }

    private void Update()
    {
        if (Lives <= 0)
        {
            Debug.Log("DIES");
            if (OnGameOver != null)
                OnGameOver?.Invoke();
        }
    }

    public void ResetBall()
    {
        PlayerController.Instance.egg.position = PlayerController.Instance.eggStart.position;
        PlayerController.Instance.SetIsPlaying(false);
    }

    public async void GameOver()
    {
        if (playerIsDead) return;
        Debug.Log("Starting video");
        playerIsDead = true;
        vidProj.SetActive(true);
        vp.Play();
        await Task.Delay((int)(vp.length * 1000 + videoDelay));
        Debug.Log("Video ended");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CheckIfDone()
    {
        if (bricksLeft <= 0)
        {
            winproj.SetActive(true);
            PlayerController.Instance.enabled = false;
        }
    }
}
