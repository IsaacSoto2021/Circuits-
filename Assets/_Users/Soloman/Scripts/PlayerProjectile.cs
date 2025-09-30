using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float lifetime = 5f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("EnemyProjectile"))
        {
            return;
        }
        Destroy(gameObject);
    }
}
