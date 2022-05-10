using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timercontroller : MonoBehaviour
{
    [SerializeField]
    [Header("")]
    float _startCount = 3;

    [SerializeField]
    [Header("")]
    Text _startCounttext;

    [SerializeField]
    [Header("ゲームプレイ中のtimerを表示させるText")]
    Text _gameplaytimerText;

    private void Start()
    {
        GameManager.instance._startTimer = true;
    }

    private void Update()
    {
        Timer();
    }
    
    public void Timer()
    {
        if (GameManager.instance._startTimer)
        {
            _startCount -= Time.deltaTime;
            _startCounttext.text = _startCount.ToString("F1");      
        }
        if (_startCount < 0)
        {     
            GameManager.instance._playerStop = false;
            GameManager.instance._EnemyStop = false;
            GameManager.instance._startTimer = false;
            _startCounttext.gameObject.SetActive(false);
            GameManager.instance._timer += Time.deltaTime;
            _gameplaytimerText.text = GameManager.instance._timer.ToString("F2");
        }

    }
}
