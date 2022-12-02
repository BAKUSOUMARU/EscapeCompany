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
        }
        if (_startCount < 0)
        {     
            GameManager.instance.StartPlayer();
            GameManager.instance.StartEnemy();
            GameManager.instance.StopTimer();
            GameManager.instance.TimerUp();
        }

    }
}
