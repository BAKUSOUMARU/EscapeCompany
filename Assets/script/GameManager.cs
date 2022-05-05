using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField] 
    [Header("ゲームオーバー時に出てくるテキスト")]
    Text _gameOverText;

    [SerializeField]
    [Header("ゲームクリア時に出てくるテキスト")]
    Text _gameClearText;

    [Header("Enemyを止めるのを検知するフラグ")]
    public bool _EnemyStop = false;

    public bool _playerStop = false;
   
    public static GameManager instance;

       
     void Awake()
    {
        if (instance  == null)
        {
            instance = this;
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
        _gameOverText.gameObject.SetActive(true);       
    }
    /// <summary>
    /// ゲームクリアの処理
    /// </summary>
    public void GameClear()
    {
        _gameClearText.gameObject.SetActive(true);
        _playerStop = true;
    }
}
