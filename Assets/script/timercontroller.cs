using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timercontroller : MonoBehaviour
{
   �@
    [SerializeField]
    [Header("�Q�[���v���C����timer��\��������Text")]
    Text _gameplaytimerText;
    
    private void Update()
    {
        Timer();
    }
    
    public void Timer()
    {
        if (!GameManager.instance._stoptimer)
        {
            GameManager.instance._timer += Time.deltaTime;
            _gameplaytimerText.text = GameManager.instance._timer.ToString("F2");
        }

    }
}
