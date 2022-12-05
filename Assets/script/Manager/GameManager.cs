using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// ゲーム内に一つしか存在しないゲームマネージャー
/// に関するscript
/// </summary>
public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public float Timer => _timer;

    public GameStartFlagManager GameStartFlagManager => _gameStartFlagManager;
 
    [Header("ゲームスタートしてからの時間")]
    private float _timer = 0;

    GameStartFlagManager _gameStartFlagManager = new GameStartFlagManager();

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
        MoneyManager.Instance.MoneyUp(StageManager.Instance.StageCount * 2); 
        _gameStartFlagManager.StartPlayer();
        SceneManager.LoadScene("GameClear");
    }

    public void GameReset()
    {
       TimeReset();
       _gameStartFlagManager.StopEnemy();
       _gameStartFlagManager.StopPlayer();
    }

    public void TimerUp()
    {
        _timer += Time.deltaTime;
    }

    public void TimeReset()
    {
        _timer = 0;
    }
}
