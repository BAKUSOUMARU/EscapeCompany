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
    [Header("ゲームスタートしてからの時間")]
    public float _timer = 0;

    [Header("Enemyを止めるのを検知するフラグ")]
    public bool enemyStop = false;

    [Header("playerを止めるのを検知するフラグ")]
    public bool playerStop = false;

    [Header("freelevelをオンにするか")]
    public bool isfreelevel = false;

    [Header("生成するステージの数")]
    public int stagecount;

    [Header("フリーレベルのステージを出す数")]
    public int freelevel;

    [Header("タイマーをスタートさせるフラグ")]
    public bool startTimer = false;

    public int money = 0;

    public static GameManager instance;

    public int skinnumber = 0;

    [SerializeField] Sprite[] _playersprite;

    public Sprite[] PlayerSprites => _playersprite; 
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
        money += stagecount; 
        playerStop = true;
        SceneManager.LoadScene("GameClear");
    }
}
