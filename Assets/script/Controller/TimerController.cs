using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///　ゲーム開始時のカウントダウンタイマーのscript
/// </summary>
public class TimerController : MonoBehaviour
{
    public float StartCount => _startCount;
    
    [SerializeField]
    [Header("スタートするまでのカウントダウン時間")]
    float _startCount = 3;


    private void Start()
    {
        GameManager.Instance.GameStartFlagManager.StartTimer();
    }

    private void Update()
    {
        Timer();
    }
    
    public void Timer()
    {
        if (GameManager.Instance.GameStartFlagManager.IsStartTimer)
        {
            _startCount -= Time.deltaTime;
        }
        if (_startCount < 0)
        {     
            GameManager.Instance.GameStartFlagManager.StartPlayer();
            GameManager.Instance.GameStartFlagManager.StartEnemy();
            GameManager.Instance.GameStartFlagManager.StopTimer();
            GameManager.Instance.TimerUp();
        }

    }
}
