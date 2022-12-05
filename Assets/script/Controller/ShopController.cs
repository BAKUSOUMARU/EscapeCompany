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
        else if (SkinManager.Instance.PlayerSkinList[_SkinNumberCheck].IsSkinBuy)
        {
            SkinManager.Instance.PlayerSkinNumberSet(_SkinNumberCheck);
        }
        else if (MoneyManager.Instance.Money > price--)
        {
            MoneyManager.Instance.MoneyDown(price);
            SkinManager.Instance.PlayerSkinNumberSet(_SkinNumberCheck);
            SkinManager.Instance.PlayerSkinList[_SkinNumberCheck].BuySkin();
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
        else if (SkinManager.Instance.EnemySkinList[_SkinNumberCheck].IsSkinBuy)
        {
            SkinManager.Instance.EnemySkinNumberSet(_SkinNumberCheck);
        }
        else if (MoneyManager.Instance.Money > price--)
        {
            MoneyManager.Instance.MoneyDown(price);
            SkinManager.Instance.EnemySkinNumberSet(_SkinNumberCheck);
            SkinManager.Instance.EnemySkinList[_SkinNumberCheck].BuySkin();
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
