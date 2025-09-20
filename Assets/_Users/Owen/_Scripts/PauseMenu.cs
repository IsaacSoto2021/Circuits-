using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject _PauseCanvas;
    public GameObject _HUDCanvas;

    void Update()
    {

    }

    public void Pause()
    {
        _PauseCanvas.SetActive(true);
        _HUDCanvas.SetActive(false);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        _PauseCanvas.SetActive(false);
        _HUDCanvas.SetActive(true);
        Time.timeScale = 1.0f;
    }

    public void Abandon()
    {

    }

    public void QuitGame()
    {
        print("Quit Game");
        Application.Quit();
    }
}