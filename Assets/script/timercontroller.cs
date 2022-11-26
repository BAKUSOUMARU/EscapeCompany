using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
///�@�Q�[���J�n���̃J�E���g�_�E���^�C�}�[��script
/// </summary>
public class TimerController : MonoBehaviour
{
    [SerializeField]
    [Header("�X�^�[�g����܂ł̃J�E���g�_�E������")]
    float _startCount = 3;

    [SerializeField]
    [Header("�J�E���g�_�E���^�C�}�[���f��Text")]
    Text _startCountText;

    [SerializeField]
    [Header("�Q�[���v���C����timer��\��������Text")]
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
