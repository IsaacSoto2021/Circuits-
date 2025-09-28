using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    public GameObject _enemy1;
    public GameObject _enemy2;
    public GameObject _enemy3;
    public GameObject _enemy4;
    public Transform _enemySpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance._spawnWave)
        {
            SpawnEnemy();
            GameManager.Instance._spawnWave = false;
        }
    }

    public void SpawnEnemy()
    {
        _enemy1.SetActive(true);
        _enemy2.SetActive(true);
        _enemy3.SetActive(true);
        _enemy4.SetActive(true);
    }

}
