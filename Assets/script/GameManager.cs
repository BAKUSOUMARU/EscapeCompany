using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float _timer = 0;

    [Header("Enemyを止めるのを検知するフラグ")]
    public bool _EnemyStop = false;

    [Header("playerを止めるのを検知するフラグ")]
    public bool _playerStop = false;

    [Header("freelevelをオンにするか")]
    public bool _isfreelevel = false;

    [Header("生成するステージの数")]
    public int _stagecount;

    public int  _freelevel;

    public bool _startTimer = false;

    public static GameManager instance;

    void Awake()
    {
        if (instance  == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }   

    /// <summary>
    /// ゲームオーバーの処理
    /// </summary>
    public void GameOver()
    {
        Debug.Log("ゲーム終了");
        SceneManager.LoadScene("GameOver");
    }
    /// <summary>
    /// ゲームクリアの処理
    /// </summary>
    public void GameClear()
    {   
        _playerStop = true;
        SceneManager.LoadScene("GameClear");
    }
}
