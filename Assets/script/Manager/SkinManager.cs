using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : SingletonMonoBehaviour<SkinManager>
{

    public List<PlayerSkin> PlayerSkinList = new List<PlayerSkin>();

    public List<EnemySkin> EnemySkinList = new List<EnemySkin>();

    public int NowPlayerSkinNumber => _nowPlayerSkinNumber;

    public int NowEnemySkinNumber => _nowEnemySkinNumder;

    private int _nowPlayerSkinNumber = 0;
   
    private int _nowEnemySkinNumder = 0;

    public void PlayerSkinNumberSet(int setSkinNumber)
    {
        _nowPlayerSkinNumber = setSkinNumber;
    }

    public void EnemySkinNumberSet(int setSkinNumber)
    {
        _nowEnemySkinNumder = setSkinNumber;
    }
}

[System.SerializableAttribute]
public class PlayerSkin
{
    public GameObject Player => _player;
    public bool IsSkinBuy => isSkinBuy;

    [SerializeField]
    GameObject _player;

    [SerializeField]
    bool isSkinBuy = false;

    public void BuySkin()
    {
        isSkinBuy = true;
    }
}

[System.SerializableAttribute]
public class EnemySkin
{
    public GameObject Enemy => _enemy;
    public bool IsSkinBuy => isSkinBuy;

    [SerializeField]
    GameObject _enemy;

    [SerializeField]
    bool isSkinBuy = false;

    public void BuySkin()
    {
        isSkinBuy = true;
    }
}