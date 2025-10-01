using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public bool _spawnWave = false;

    public GameObject _playerControllerPrefab;

    public Transform _spawnPoint;
    void Update()
    {

    }
    private void Start()
    {
    }
    public void ResetPos()
    {
        _playerControllerPrefab.transform.position = _spawnPoint.transform.position;
        PlayerData.Instance.SetValues();
    }
    public void spawn()
    {
        Instantiate(_playerControllerPrefab, _spawnPoint);
        PlayerData.Instance.SetValues();
    }
    public void Quit()
    {
        print("Quit Game");
        Application.Quit();
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
        ResetPos();
    }
    public void Shop()
    {
        SceneManager.LoadScene(2);
    }
    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}
