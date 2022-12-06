using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    [SerializeField] 
    ShopCatalog _shopCatalog;
    
    [SerializeField] 
    int _SkinNumberCheck;

    [SerializeField]
    int _price = 200;

    [SerializeField] 
    GameObject _popUp;
    
    [SerializeField] 
    GameObject _popUp2;

    public void ShopSell()
    {
        switch (_shopCatalog)
        {
            case ShopCatalog.Player:
                PlayerSkinBuy(_price);
                break;
            case ShopCatalog.Enemy:
                EnemySkinBuy(_price);
                break;
        }
    }

    void PlayerSkinBuy(int price)
    {
        if (SkinManager.Instance.NowPlayerSkinNumber == _SkinNumberCheck)
        {
            _popUp2.SetActive(true);
        }
        else if (SaveDataManager.Instance.PlayerSkinCheck(_SkinNumberCheck))
        {
            SkinManager.Instance.PlayerSkinNumberSet(_SkinNumberCheck);
        }
        else if (SaveDataManager.Instance.Money >= price--)
        {
            SaveDataManager.Instance.MoneyDown(price);
            SkinManager.Instance.PlayerSkinNumberSet(_SkinNumberCheck);
            SaveDataManager.Instance.PlayerSkinBuy(_SkinNumberCheck);
            SaveDataManager.Instance.Save();
        }
        else
        {
            _popUp.SetActive(true);
        }
    }

    void EnemySkinBuy(int price)
    {
        if (SkinManager.Instance.NowEnemySkinNumber == _SkinNumberCheck)
        {
            _popUp2.SetActive(true);
        }
        else if (SaveDataManager.Instance.EnemySkintCheck(_SkinNumberCheck))
        {
            SkinManager.Instance.EnemySkinNumberSet(_SkinNumberCheck);
        }
        else if (SaveDataManager.Instance.Money >= price--)
        {
            SaveDataManager.Instance.MoneyDown(price);
            SkinManager.Instance.EnemySkinNumberSet(_SkinNumberCheck);
            SaveDataManager.Instance.EnemySkinBuy(_SkinNumberCheck);
            SaveDataManager.Instance.Save();
        }
        else
        {
            _popUp.SetActive(true);
        }
    }

    enum ShopCatalog
    {
        Player,
        Enemy
    }
    
}
