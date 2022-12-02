using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerView : MonoBehaviour
{
    [SerializeField]
    [Header("�J�E���g�_�E���^�C�}�[���f��Text")]
    Text _startCountText;

    [SerializeField]
    [Header("�Q�[���v���C����timer��\��������Text")]
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
