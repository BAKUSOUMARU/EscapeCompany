using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stagecontroller : MonoBehaviour
{
    [SerializeField]
    [Header("生成するステージのprefab")]
    GameObject[] _stage;

    [SerializeField]
    [Header("生成するステージの数")]
    int _stagecount;

    [SerializeField]
    [Header("ゴールステージのprefab")]
    GameObject _goalObject;

    [SerializeField]
    [Header("生成する背景のprefab")]
    GameObject _backscreen;

   [SerializeField]
   [Header("自動生成で足りない分の背景を追加する数")]
    int _addBackseason = 3;
    /// <summary>
    /// 生成するステージの間隔
    /// </summary>
    private float _stageSpawninterval;
    
    /// <summary>
    /// 生成する背景の間隔
    /// </summary>
    private float _backScreenSpawnimterval;


    private void Start()
    {

        
        BackScreenSpawn();
        StageSpawn();
    }

    /// <summary>
    /// ステージを生成する処理
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
        
        　Instantiate(_goalObject, new Vector2(_stageSpawninterval, 0), transform.rotation);
        
    }

    /// <summary>
    /// 背景を生成する処理
    /// </summary>
    public void BackScreenSpawn()
    {
        if (_stagecount / 5 > 0)
        {
            _addBackseason += _stagecount / 4;
        }
        Debug.Log("出たよ");
        _backScreenSpawnimterval = (float)-14.5;
        
        for (int i = 0; i < _stagecount + _addBackseason; i++)
        {
            Instantiate(_backscreen, new Vector3(_backScreenSpawnimterval, 0f, 10f), transform.rotation);
            _backScreenSpawnimterval += (float)14.5;
        }
    }
}
