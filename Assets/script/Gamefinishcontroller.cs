using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �Q�[���I�����̏���
/// </summary>
public class Gamefinishcontroller : MonoBehaviour
{

    [SerializeField]
    [Header("�Q�[���I�����̎��Ԃ�\��������Text")]
    Text _timertext;

    [SerializeField]
    Text _moneytext;

    [SerializeField]
    [Header("�Q�[���I������̏����̕ύX")]
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
                _timertext.text = "���͑ސE����񂾁I�I";
                break;
            case Gamefinishmode.GameClear:
                _moneytext.text = "������" + GameManager.instance.Money + "�~";
                _timertext.text = "�ސE�܂ł̎���"�@+�@GameManager.instance.Timer.ToString("F2") + "�b";
                break;
            default:
                break;
        }

    }
    
    /// <summary>
    /// �Q�[���I������̏����؂�ւ�
    /// </summary>
    enum Gamefinishmode
    {
        GameOver,
        GameClear
    }
}
