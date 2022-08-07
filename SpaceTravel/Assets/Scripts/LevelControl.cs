using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    // Start is called before the first frame update

    public string retry;
    public string home;
    public string nextlevel;

    public GameObject PausePanel;
    public GameObject pause;

    private void Start()
    {
        pause.SetActive(true);
    }

    public void Nextlevel()
    {
        SceneManager.LoadScene(nextlevel);
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(home);
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(retry);
    }

    public void Back()
    {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
        pause.SetActive(true);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pause.SetActive(false);
        PausePanel.SetActive(true);
    }
}
