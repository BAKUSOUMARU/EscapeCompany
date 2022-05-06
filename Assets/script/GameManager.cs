using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   

    [SerializeField] 
    [Header("ゲームオーバー時に出てくるテキスト")]
    Text _gameOverText;

    [SerializeField]
    [Header("ゲームクリア時に出てくるテキスト")]
    Text _gameClearText;

    public float _timer = 0;

    public bool _stoptimer = false;

    [Header("Enemyを止めるのを検知するフラグ")]
    public bool _EnemyStop = false;

    public bool _playerStop = false;
   
    public static GameManager instance;

       
     void Awake()
    {
        if (instance  == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
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
        _stoptimer = true;
        SceneManager.LoadScene("GameOver");
    }
    /// <summary>
    /// ゲームクリアの処理
    /// </summary>
    public void GameClear()
    {
        _gameClearText.gameObject.SetActive(true);
        _stoptimer = true;
        _playerStop = true;
        SceneManager.LoadScene("GameClear");
    }
}
