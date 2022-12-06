using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : SingletonMonoBehaviour<SkinManager>
{
    public GameObject[] Player => _player;
    public GameObject[] Enemy => _enemy;

    [SerializeField]
    GameObject[] _player;

    [SerializeField]
    GameObject[] _enemy;
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