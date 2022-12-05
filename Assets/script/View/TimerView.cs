using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerView : MonoBehaviour
{
    [SerializeField]
    [Header("カウントダウンタイマーを映すText")]
    Text _startCountText;

    [SerializeField]
    [Header("ゲームプレイ中のtimerを表示させるText")]
    Text _gamePlayTimerText;

    public void ChangeStartTimer(float timer)
    {
        _startCountText.text = timer.ToString("F1");
        if (timer < 0)
        {
            _startCountText.gameObject.SetActive(false);
        }
    }

    public void ChangeTimer(float timer)
    {
        _gamePlayTimerText.text = timer.ToString("F2");
    }
   
}
