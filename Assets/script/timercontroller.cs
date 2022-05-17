using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
///�@�Q�[���J�n���̃J�E���g�_�E���^�C�}�[��script
/// </summary>
public class timercontroller : MonoBehaviour
{
    [SerializeField]
    [Header("�X�^�[�g����܂ł̃J�E���g�_�E������")]
    float _startCount = 3;

    [SerializeField]
    [Header("�J�E���g�_�E���^�C�}�[���f��Text")]
    Text _startCounttext;

    [SerializeField]
    [Header("�Q�[���v���C����timer��\��������Text")]
    Text _gameplaytimerText;

    private void Start()
    {
        GameManager.instance.startTimer = true;
    }

    private void Update()
    {
        Timer();
    }
    
    public void Timer()
    {
        if (GameManager.instance.startTimer)
        {
            _startCount -= Time.deltaTime;
            _startCounttext.text = _startCount.ToString("F1");      
        }
        if (_startCount < 0)
        {     
            GameManager.instance.playerStop = false;
            GameManager.instance.enemyStop = false;
            GameManager.instance.startTimer = false;
            _startCounttext.gameObject.SetActive(false);
            GameManager.instance._timer += Time.deltaTime;
            _gameplaytimerText.text = GameManager.instance._timer.ToString("F2");
        }

    }
}
