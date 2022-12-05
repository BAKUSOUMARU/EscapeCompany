using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    [SerializeField] ShopCatalog shopCatalog;
    [SerializeField] int _skinnumberchuck;
    [SerializeField] GameObject _popUp;
    
    [SerializeField] GameObject _popUp2;

    public void ShopSell()
    {
        switch (shopCatalog)
        {
            case ShopCatalog.Player1:
                if(SkinManager.Instance.NowPlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (MoneyManager.Instance.Money > 199)
                {
                    MoneyManager.Instance.MoneyDown(200);
                    SkinManager.Instance.PlayerSkinNumberSet(0);
                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Player2:
                if (SkinManager.Instance.NowPlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (MoneyManager.Instance.Money > 199)
                {
                    MoneyManager.Instance.MoneyDown(200);
                    SkinManager.Instance.PlayerSkinNumberSet(1);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Player3:
                if (SkinManager.Instance.NowPlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (MoneyManager.Instance.Money > 199)
                {
                    MoneyManager.Instance.MoneyDown(200);
                    SkinManager.Instance.PlayerSkinNumberSet(2);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Player4:
                if (SkinManager.Instance.NowPlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (MoneyManager.Instance.Money > 199)
                {
                    MoneyManager.Instance.MoneyDown(200);
                    SkinManager.Instance.PlayerSkinNumberSet(3);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Player5:
                if (SkinManager.Instance.NowPlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (MoneyManager.Instance.Money > 199)
                {
                    MoneyManager.Instance.MoneyDown(200);
                    SkinManager.Instance.PlayerSkinNumberSet(4);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Player6:
                if (SkinManager.Instance.NowPlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (MoneyManager.Instance.Money > 199)
                {
                    MoneyManager.Instance.MoneyDown(200);
                    SkinManager.Instance.PlayerSkinNumberSet(5);

                }
                else
                {
                    _popUp.SetActive(true);
                }

                break;
            case ShopCatalog.Player7:
                if (SkinManager.Instance.NowPlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (MoneyManager.Instance.Money > 499)
                {
                    MoneyManager.Instance.MoneyDown(500);
                    SkinManager.Instance.PlayerSkinNumberSet(6);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Enemy1:
                if (SkinManager.Instance.NowEnemySkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (MoneyManager.Instance.Money > 299)
                {
                    MoneyManager.Instance.MoneyDown(300);
                    SkinManager.Instance.EnemySkinNumberSet(0);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Enemy2:
                if (SkinManager.Instance.NowEnemySkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (MoneyManager.Instance.Money > 299)
                {
                    MoneyManager.Instance.MoneyDown(300);
                    SkinManager.Instance.EnemySkinNumberSet(1);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Enemy3:
                if (SkinManager.Instance.NowEnemySkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (MoneyManager.Instance.Money > 299)
                {
                    MoneyManager.Instance.MoneyDown(300);
                    SkinManager.Instance.EnemySkinNumberSet(2);
                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
        }
    }

    enum ShopCatalog
    {
        Player1,
        Player2,
        Player3,
        Player4,
        Player5,
        Player6,
        Player7,
        Enemy1,
        Enemy2,
        Enemy3,
    }
    
}
