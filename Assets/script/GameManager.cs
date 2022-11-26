using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// ゲーム内に一つしか存在しないゲームマネージャー
/// に関するscript
/// </summary>
public class GameManager : MonoBehaviour
{
    public float Timer => _timer;
    public int FreeLevel => _freeLevel;

    public int PlayerSkinNumber => _playerSkinNumber;

    public int EnemySkinNumder => _enemySkinNumder;

    public int StageCount => _stagecount;

    public int Money => _money;

    public bool IsEnemyStop => isEnemyStop;

    public bool IsPlayerStop => isPlayerStop;

    public bool IsFreeLevel => isFreeLevel;
    public bool IsStartTimer => isStartTimer;
    public GameObject[] Playes => _player;
    public GameObject[] Enemy => _Enemy;

    public static GameManager instance;
   
    [Header("ゲームスタートしてからの時間")]
    private float _timer = 0;

    [Header("生成するステージの数")]
    private int _stagecount;

    [Header("フリーレベルのステージを出す数")]
    private int _freeLevel;

    private int _money = 0;

    private int _playerSkinNumber = 0;

    private int _enemySkinNumder = 0;
    
    [Header("Enemyを止めるのを検知するフラグ")]
    private bool isEnemyStop = false;

    [Header("playerを止めるのを検知するフラグ")]
    private bool isPlayerStop = false;

    [Header("freelevelをオンにするか")]
    private bool isFreeLevel = false;

    [Header("タイマーをスタートさせるフラグ")]
    private bool isStartTimer = false;

    [SerializeField] 
    private GameObject[] _player;

    [SerializeField] 
    private GameObject[] _Enemy;

    /// <summary>
    ///ゲームマネージャーをscene内に一つだけ存在するようにする処理
    ///とDontDestroyOnLoadを呼ぶ処理
    /// </summary>
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
        MoneyUp(_stagecount* 2); 
        isPlayerStop = true;
        SceneManager.LoadScene("GameClear");
    }

    public void GameReset()
    {
       TimeReset();
       StartEnemy();
       StartPlayer();
    }

    public void TimerUp()
    {
        _timer += Time.deltaTime;
    }

    public void TimeReset()
    {
        _timer = 0;
    }

    public void StageCountSet(int setCount)
    {
        _stagecount = setCount;
    }

    public void FreeStageCountSet(int setCount)
    {
        _freeLevel = setCount;
    }

    public void MoneyUp(int addMoney)
    {
        _money += addMoney;
    }
    public void PlayerSkinNumberSet(int setSkinNumber)
    {
        _playerSkinNumber = setSkinNumber;
    }

    public void EnemySkinNumberSet(int setSkinNumber)
    {
        _enemySkinNumder = setSkinNumber;
    }


    public void MoneyDown(int addMoney)
    {
        _money -= addMoney;
    }

    public void StopPlayer()
    {
        isPlayerStop =true;
    }

    public void StartPlayer()
    {
        isPlayerStop = false;
    }

    public void StopEnemy()
    {
        isEnemyStop=true;
    }

    public void StartEnemy()
    {
        isEnemyStop=false;
    }

    public void FreeLevelOn()
    {
        isFreeLevel = true;
    }

    public void FreeLevelOff()
    {
        isFreeLevel=false;
    }

    public void StartTimer()
    {
        isStartTimer = true;
    }

    public void StopTimer()
    {
        isStartTimer=false;
    }
}
