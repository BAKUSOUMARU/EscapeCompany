using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField] 
    [Header("�Q�[���I�[�o�[���ɏo�Ă���e�L�X�g")]
    Text _gameOverText;

    [SerializeField]
    [Header("�Q�[���N���A���ɏo�Ă���e�L�X�g")]
    Text _gameClearText;

    [Header("Enemy���~�߂�̂����m����t���O")]
    public bool _EnemyStop = false;

    public bool _playerStop = false;
   
    public static GameManager instance;

       
     void Awake()
    {
        if (instance  == null)
        {
            instance = this;
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
    }
    /// <summary>
    /// �Q�[���N���A�̏���
    /// </summary>
    public void GameClear()
    {
        _gameClearText.gameObject.SetActive(true);
        _playerStop = true;
    }
}
