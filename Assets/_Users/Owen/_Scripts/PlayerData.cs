using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerData : Singleton<PlayerData>
{
    public int _maxHp = 100;
    public int _Hp = 0;
    public int _hpTier = 1;
    public int _scrap = 0;
    public int _damage = 50;

    public bool _hasKeycard;

    public void SetValues()
    {
        _Hp = _maxHp;
    }

    private void Start()
    {
        SetValues();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("EnemyProjectile20"))
        {
            _Hp -= 20;
            if (_Hp <= 0)
            {
                //call gameover from gamemanger
            }
        }
    }
    
}
