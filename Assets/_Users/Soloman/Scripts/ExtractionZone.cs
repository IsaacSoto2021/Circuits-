using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtractionZone : MonoBehaviour
{
    public float requiredTimeInZone = 10f;
    public string winSceneName = "WinScreen"; // Set to name of win scene

    private float timer = 0f;
    private bool playerInside = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            timer = 0f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
            timer = 0f;
        }
    }

    void Update()
    {
        if (playerInside)
        {
            timer += Time.deltaTime;

            if (timer >= requiredTimeInZone)
            {
                Debug.Log("Player extracted! Loading win scene: " + winSceneName);
                SceneManager.LoadScene(winSceneName);
            }
        }
    }

}
