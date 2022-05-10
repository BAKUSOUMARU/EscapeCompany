using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float _timer = 0;

    [Header("Enemy���~�߂�̂����m����t���O")]
    public bool _EnemyStop = false;

    [Header("player���~�߂�̂����m����t���O")]
    public bool _playerStop = false;

    [Header("freelevel���I���ɂ��邩")]
    public bool _isfreelevel = false;

    [Header("��������X�e�[�W�̐�")]
    public int _stagecount;

    public int  _freelevel;

    public bool _startTimer = false;

    public static GameManager instance;

    void Awake()
    {
        if (instance  == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }   

    /// <summary>
    /// �Q�[���I�[�o�[�̏���
    /// </summary>
    public void GameOver()
    {
        Debug.Log("�Q�[���I��");
        SceneManager.LoadScene("GameOver");
    }
    /// <summary>
    /// �Q�[���N���A�̏���
    /// </summary>
    public void GameClear()
    {   
        _playerStop = true;
        SceneManager.LoadScene("GameClear");
    }
}
