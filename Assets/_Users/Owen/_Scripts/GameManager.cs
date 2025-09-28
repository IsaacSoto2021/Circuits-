using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public bool _spawnWave = false;
    void Update()
    {

    }
    private void Start()
    {
        _spawnWave = true;
    }
}
