using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    public GameObject _enemyToSpawn;
    public int _numEnemies;
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
        for (int j = 0; j < _numEnemies; j++)
        {
            GameObject _enemySpawned = Instantiate(_enemyToSpawn, _enemySpawn);
            NavMeshAgent agent = _enemySpawned.GetComponent<NavMeshAgent>();
            if (agent != null)
            {
                NavMeshHit hit;
                if (NavMesh.SamplePosition(_enemySpawn.position, out hit, 1.0f, NavMesh.AllAreas))
                {
                    agent.Warp(hit.position);
                }
            }
        }
    }

}
