using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ゲーム終了時の処理
/// </summary>
public class GameFinishController : MonoBehaviour
{

    [SerializeField]
    [Header("ゲーム終了時の時間を表示させるText")]
    Text _timertext;

    [SerializeField]
    Text _moneytext;

    [SerializeField]
    [Header("ゲーム終了時後の処理の変更")]
    Gamefinishmode _gamefinishmode;
    
    void Start()
    {
        GameFinish();
    }

    public void GameFinish()
    {
        switch (_gamefinishmode)
        {
            case Gamefinishmode.GameOver:
                _timertext.text = "次は退職するんだ！！";
                break;
            case Gamefinishmode.GameClear:
                _moneytext.text = "所持金" + GameManager.instance.Money + "円";
                _timertext.text = "退職までの時間"　+　GameManager.instance.Timer.ToString("F2") + "秒";
                break;
            default:
                break;
        }

    }
    
    /// <summary>
    /// ゲーム終了時後の処理切り替え
    /// </summary>
    enum Gamefinishmode
    {
        GameOver,
        GameClear
    }
}
