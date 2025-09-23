using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{

    public GameObject _ScrapPrefab;
    public Transform _SpawnPos1;
    public Transform _SpawnPos2;
    public Transform _SpawnPos3;
    public Transform _SpawnPos4;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject Scrap1 = Instantiate(_ScrapPrefab, _SpawnPos1);
            GameObject Scrap2 = Instantiate(_ScrapPrefab, _SpawnPos2);
            GameObject Scrap3 = Instantiate(_ScrapPrefab, _SpawnPos3);
            GameObject Scrap4 = Instantiate(_ScrapPrefab, _SpawnPos4);
            /*  PlayerData.Instance._scrap += Random.Range(2, 5);
              print("Your scrap is: " + PlayerData.Instance._scrap); */
        }
    }
}
