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
                if(GameManager.instance.PlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (GameManager.instance.Money > 199)
                {
                    GameManager.instance.MoneyDown(200);
                    GameManager.instance.PlayerSkinNumberSet(0);
                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Player2:
                if (GameManager.instance.PlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (GameManager.instance.Money > 199)
                {
                    GameManager.instance.MoneyDown(200);
                    GameManager.instance.PlayerSkinNumberSet(1);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Player3:
                if (GameManager.instance.PlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (GameManager.instance.Money > 199)
                {
                    GameManager.instance.MoneyDown(200);
                    GameManager.instance.PlayerSkinNumberSet(2);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Player4:
                if (GameManager.instance.Money > 199)
                {
                    GameManager.instance.MoneyDown(200);
                    GameManager.instance.PlayerSkinNumberSet(3);

                }
                else if (GameManager.instance.PlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Player5:
                if (GameManager.instance.PlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (GameManager.instance.Money > 199)
                {
                    GameManager.instance.MoneyDown(200);
                    GameManager.instance.PlayerSkinNumberSet(4);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Player6:
                if (GameManager.instance.PlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (GameManager.instance.Money > 199)
                {
                    GameManager.instance.MoneyDown(200);
                    GameManager.instance.PlayerSkinNumberSet(5);

                }
                else
                {
                    _popUp.SetActive(true);
                }

                break;
            case ShopCatalog.Player7:
                if (GameManager.instance.PlayerSkinNumber == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (GameManager.instance.Money > 499)
                {
                    GameManager.instance.MoneyDown(500);
                    GameManager.instance.PlayerSkinNumberSet(6);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Enemy1:
                if (GameManager.instance.EnemySkinNumder == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (GameManager.instance.Money > 299)
                {
                    GameManager.instance.MoneyDown(300);
                    GameManager.instance.EnemySkinNumberSet(0);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Enemy2:
                if (GameManager.instance.EnemySkinNumder == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (GameManager.instance.Money > 299)
                {
                    GameManager.instance.MoneyDown(300);
                    GameManager.instance.EnemySkinNumberSet(1);

                }
                else
                {
                    _popUp.SetActive(true);
                }
                break;
            case ShopCatalog.Enemy3:
                if (GameManager.instance.EnemySkinNumder == _skinnumberchuck)
                {
                    _popUp2.SetActive(true);
                }
                else if (GameManager.instance.Money > 299)
                {
                    GameManager.instance.MoneyDown(300);
                    GameManager.instance.EnemySkinNumberSet(2);
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
