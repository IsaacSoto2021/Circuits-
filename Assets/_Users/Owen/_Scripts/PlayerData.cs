using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerData : Singleton<PlayerData>
{
    public int _maxHp = 100;
    public int _hpTier = 1;
    public int _currency = 20;

}
