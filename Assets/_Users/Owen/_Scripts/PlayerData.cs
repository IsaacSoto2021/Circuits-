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
    public int _damage = 60;

    public bool _hasKeycard;

    public void Spawn()
    {
        _Hp = _maxHp;
    }

    private void Start()
    {
        Spawn();
    }
}
