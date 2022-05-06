using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ゲーム終了時の処理
/// </summary>
public class Gamefinishcontroller : MonoBehaviour
{

    [SerializeField]
    [Header("ゲーム終了時の時間を表示させるText")]
    Text _timertext;

    [SerializeField]
    [Header("ゲーム終了時後の処理の変更")]
    Gamefinishmode gamefinishmode;
    
    void Start()
    {
        GameFinish();
    }

    public void GameFinish()
    {
        switch (gamefinishmode)
        {
            case Gamefinishmode.GameOver:
                _timertext.text = GameManager.instance._timer.ToString("F2");
                break;
            case Gamefinishmode.GameClear:
                _timertext.text = GameManager.instance._timer.ToString("F2");
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
