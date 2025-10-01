using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject _PauseCanvas;
    public GameObject _HUDCanvas;
    public GameObject _ConfirmAbandonCanvas;

    public int _SceneToAbandonTo = 0;

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
        _ConfirmAbandonCanvas.SetActive(true);
    }

    public void ConfirmAbandon()
    {
        SceneManager.LoadSceneAsync(_SceneToAbandonTo);
    }

    public void Return()
    {
        _ConfirmAbandonCanvas.SetActive(false);
    }

    public void QuitGame()
    {
        print("Quit Game");
        Application.Quit();
    }
}