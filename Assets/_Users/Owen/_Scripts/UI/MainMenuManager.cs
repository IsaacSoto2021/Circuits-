using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; //SPLIT THIS BY SCENE B4 IMPLEMENTATION !!!IMPORTANT!!!

public class MainMenuManager : MonoBehaviour
{
    public TMP_Text _scrapText;
    public TMP_Text _hpUpgradeCostText;

    public void Update()
    {
        int _scrap = PlayerData.Instance._scrap;
        int _hpUpgradeCost = (PlayerData.Instance._hpTier * 20);

        _scrapText.SetText("Currency: " + _scrap);
        _hpUpgradeCostText.SetText(_hpUpgradeCost + " Currency");
    }
    public void ClickQuit()
    {
        print("Quit Game");
        Application.Quit();
    }
    public void ClickPlay()
    {
        SceneManager.LoadSceneAsync(1);
        print(PlayerData.Instance._maxHp);
    }
    public void ClickShop()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void ClickReturn()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void ClickHPUpgrade()
    {
        if (PlayerData.Instance._scrap >= (PlayerData.Instance._hpTier * 20) && PlayerData.Instance._hpTier < 5)
        {
            PlayerData.Instance._scrap -= (PlayerData.Instance._hpTier * 20);
            PlayerData.Instance._hpTier++;
            PlayerData.Instance._maxHp += 20;
        }
    }
}
