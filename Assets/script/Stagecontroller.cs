using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stagecontroller : MonoBehaviour
{
    [SerializeField]
    [Header("��������X�e�[�W��prefab")]
    GameObject[] _stage;

    [SerializeField]
    [Header("��������X�e�[�W�̐�")]
    int _stagecount;

    [SerializeField]
    [Header("�S�[���X�e�[�W��prefab")]
    GameObject _goalObject;

    [SerializeField]
    [Header("��������w�i��prefab")]
    GameObject _backscreen;

   [SerializeField]
   [Header("���������ő���Ȃ����̔w�i��ǉ����鐔")]
    int _addBackseason = 3;
    /// <summary>
    /// ��������X�e�[�W�̊Ԋu
    /// </summary>
    private float _stageSpawninterval;
    
    /// <summary>
    /// ��������w�i�̊Ԋu
    /// </summary>
    private float _backScreenSpawnimterval;


    private void Start()
    {

        
        BackScreenSpawn();
        StageSpawn();
    }

    /// <summary>
    /// �X�e�[�W�𐶐����鏈��
    /// </summary>
    public void StageSpawn()
    {
        _stageSpawninterval = 0;
        for (int i = 0; i < _stagecount; i++)
        {
            int randomIndex = Random.Range(0, _stage.Length);
            Instantiate(_stage[randomIndex], new Vector2(_stageSpawninterval, 0), transform.rotation);
            _stageSpawninterval += 18f;
        }
        
        �@Instantiate(_goalObject, new Vector2(_stageSpawninterval, 0), transform.rotation);
        
    }

    /// <summary>
    /// �w�i�𐶐����鏈��
    /// </summary>
    public void BackScreenSpawn()
    {
        if (_stagecount / 5 > 0)
        {
            _addBackseason += _stagecount / 4;
        }
        Debug.Log("�o����");
        _backScreenSpawnimterval = (float)-14.5;
        
        for (int i = 0; i < _stagecount + _addBackseason; i++)
        {
            Instantiate(_backscreen, new Vector3(_backScreenSpawnimterval, 0f, 10f), transform.rotation);
            _backScreenSpawnimterval += (float)14.5;
        }
    }
}
