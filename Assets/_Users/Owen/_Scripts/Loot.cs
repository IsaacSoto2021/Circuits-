using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{


    private void OnTriggerEnter(Collider collision) //since i dont have Solomons player yet im going to wire this to being "1" key
    {
        if (collision.CompareTag("Player"))
        {
            PlayerData.Instance._currency += Random.Range(2, 5);
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PlayerData.Instance._currency += Random.Range(2, 5);
            print("Your Currency Is: " + PlayerData.Instance._currency);
            Destroy(gameObject);
        }
    }
}
