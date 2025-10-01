using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHPSystem : MonoBehaviour
{
    public int _HP = 100;
    public int _Damage = 20;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("PlayerProjectile"))
        {
            TakeDamage();
        }

    }
    public void TakeDamage()
    {
        _HP -= PlayerData.Instance._damage;
        if (_HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
