using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] _stage;
    [SerializeField] int _stagecount;
    [SerializeField] GameObject _goalObject;
    private float _stageSpawninterval;
    private float _backScreenSpawnimterval;
    [SerializeField] GameObject _backscreen;

    int _addBackseason = 3;

    [SerializeField] 
    [Header("�Q�[���I�[�o�[���ɏo�Ă���e�L�X�g")]
    Text _gameOverText;

    [SerializeField]
    [Header("�Q�[���N���A���ɏo�Ă���e�L�X�g")]
    Text _gameClearText;

    [SerializeField] Text _scoreText;

    [SerializeField] float _score = 0;
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
    private void Start()
    {
        
        if ( _stagecount /5 >0)
        {
            _addBackseason += _stagecount / 4;
        }
        Debug.Log(_addBackseason);
        BackScreenSpawn();
        StageSpawn();
    }

    private void Update()
    {
        _score += Time.deltaTime;
        Debug.Log(_score);
    }


    public void StageSpawn()
    {
        _stageSpawninterval = 0;
        for (int i = 0; i < _stagecount; i++)
        {
            int randomIndex = Random.Range(0, _stage.Length);
            Instantiate(_stage[randomIndex], new Vector2(_stageSpawninterval, 0), transform.rotation);
            _stageSpawninterval += 18f;
        }
        Instantiate(_goalObject, new Vector2(_stageSpawninterval, 0), transform.rotation);
    }

    public void BackScreenSpawn()
    {
        Debug.Log("�o����");
        _backScreenSpawnimterval = (float)-14.5;
        for (int i = 0; i < _stagecount + _addBackseason; i++)
        {
            Instantiate(_backscreen, new Vector3(_backScreenSpawnimterval, 0f, 10f), transform.rotation);
            _backScreenSpawnimterval += (float)14.5;
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
