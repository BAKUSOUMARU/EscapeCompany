using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
///　ゲーム開始時のカウントダウンタイマーのscript
/// </summary>
public class TimerController : MonoBehaviour
{
    [SerializeField]
    [Header("スタートするまでのカウントダウン時間")]
    float _startCount = 3;

    [SerializeField]
    [Header("カウントダウンタイマーを映すText")]
    Text _startCountText;

    [SerializeField]
    [Header("ゲームプレイ中のtimerを表示させるText")]
    Text _gamePlayTimerText;

    private void Start()
    {
        GameManager.instance.StartTimer();
    }

    private void Update()
    {
        Timer();
    }
    
    public void Timer()
    {
        if (GameManager.instance.IsStartTimer)
        {
            _startCount -= Time.deltaTime;
            _startCountText.text = _startCount.ToString("F1");      
        }
        if (_startCount < 0)
        {     
            GameManager.instance.StartPlayer();
            GameManager.instance.StartEnemy();
            GameManager.instance.StopTimer();
            _startCountText.gameObject.SetActive(false);
            GameManager.instance.TimerUp();
            _gamePlayTimerText.text = GameManager.instance.Timer.ToString("F2");
        }

    }
}
