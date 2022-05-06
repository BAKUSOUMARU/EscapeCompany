using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float _timer = 0;

    [Header("�^�C�}�[���~�߂�t���O")]
    public bool _stoptimer = false;

    [Header("Enemy���~�߂�̂����m����t���O")]
    public bool _EnemyStop = false;

    [Header("player���~�߂�̂����m����t���O")]
    public bool _playerStop = false;
   
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
        _stoptimer = true;
        SceneManager.LoadScene("GameOver");
    }
    /// <summary>
    /// �Q�[���N���A�̏���
    /// </summary>
    public void GameClear()
    {
        _stoptimer = true;
        _playerStop = true;
        SceneManager.LoadScene("GameClear");
    }
}
