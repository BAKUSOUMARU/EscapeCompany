using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   

    [SerializeField] 
    [Header("�Q�[���I�[�o�[���ɏo�Ă���e�L�X�g")]
    Text _gameOverText;

    [SerializeField]
    [Header("�Q�[���N���A���ɏo�Ă���e�L�X�g")]
    Text _gameClearText;

    public float _timer = 0;

    public bool _stoptimer = false;

    [Header("Enemy���~�߂�̂����m����t���O")]
    public bool _EnemyStop = false;

    public bool _playerStop = false;
   
    public static GameManager instance;

       
     void Awake()
    {
        if (instance  == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
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
        _gameOverText.gameObject.SetActive(true);
        _stoptimer = true;
        SceneManager.LoadScene("GameOver");
    }
    /// <summary>
    /// �Q�[���N���A�̏���
    /// </summary>
    public void GameClear()
    {
        _gameClearText.gameObject.SetActive(true);
        _stoptimer = true;
        _playerStop = true;
        SceneManager.LoadScene("GameClear");
    }
}
