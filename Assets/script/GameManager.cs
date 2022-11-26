using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// �Q�[�����Ɉ�������݂��Ȃ��Q�[���}�l�[�W���[
/// �Ɋւ���script
/// </summary>
public class GameManager : MonoBehaviour
{
    public float Timer => _timer;
    public int FreeLevel => _freeLevel;

    public int PlayerSkinNumber => _playerSkinNumber;

    public int EnemySkinNumder => _enemySkinNumder;

    public int StageCount => _stagecount;

    public int Money => _money;

    public bool IsEnemyStop => isEnemyStop;

    public bool IsPlayerStop => isPlayerStop;

    public bool IsFreeLevel => isFreeLevel;
    public bool IsStartTimer => isStartTimer;
    public GameObject[] Playes => _player;
    public GameObject[] Enemy => _Enemy;

    public static GameManager instance;
   
    [Header("�Q�[���X�^�[�g���Ă���̎���")]
    private float _timer = 0;

    [Header("��������X�e�[�W�̐�")]
    private int _stagecount;

    [Header("�t���[���x���̃X�e�[�W���o����")]
    private int _freeLevel;

    private int _money = 0;

    private int _playerSkinNumber = 0;

    private int _enemySkinNumder = 0;
    
    [Header("Enemy���~�߂�̂����m����t���O")]
    private bool isEnemyStop = false;

    [Header("player���~�߂�̂����m����t���O")]
    private bool isPlayerStop = false;

    [Header("freelevel���I���ɂ��邩")]
    private bool isFreeLevel = false;

    [Header("�^�C�}�[���X�^�[�g������t���O")]
    private bool isStartTimer = false;

    [SerializeField] 
    private GameObject[] _player;

    [SerializeField] 
    private GameObject[] _Enemy;

    /// <summary>
    ///�Q�[���}�l�[�W���[��scene���Ɉ�������݂���悤�ɂ��鏈��
    ///��DontDestroyOnLoad���Ăԏ���
    /// </summary>
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
        MoneyUp(_stagecount* 2); 
        isPlayerStop = true;
        SceneManager.LoadScene("GameClear");
    }

    public void GameReset()
    {
       TimeReset();
       StartEnemy();
       StartPlayer();
    }

    public void TimerUp()
    {
        _timer += Time.deltaTime;
    }

    public void TimeReset()
    {
        _timer = 0;
    }

    public void StageCountSet(int setCount)
    {
        _stagecount = setCount;
    }

    public void FreeStageCountSet(int setCount)
    {
        _freeLevel = setCount;
    }

    public void MoneyUp(int addMoney)
    {
        _money += addMoney;
    }
    public void PlayerSkinNumberSet(int setSkinNumber)
    {
        _playerSkinNumber = setSkinNumber;
    }

    public void EnemySkinNumberSet(int setSkinNumber)
    {
        _enemySkinNumder = setSkinNumber;
    }


    public void MoneyDown(int addMoney)
    {
        _money -= addMoney;
    }

    public void StopPlayer()
    {
        isPlayerStop =true;
    }

    public void StartPlayer()
    {
        isPlayerStop = false;
    }

    public void StopEnemy()
    {
        isEnemyStop=true;
    }

    public void StartEnemy()
    {
        isEnemyStop=false;
    }

    public void FreeLevelOn()
    {
        isFreeLevel = true;
    }

    public void FreeLevelOff()
    {
        isFreeLevel=false;
    }

    public void StartTimer()
    {
        isStartTimer = true;
    }

    public void StopTimer()
    {
        isStartTimer=false;
    }
}
