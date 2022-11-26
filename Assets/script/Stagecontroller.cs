using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ステージの自動生成のscript
/// </summary>
public class Stagecontroller : MonoBehaviour
{
    [SerializeField]
    [Header("生成するステージのprefab")]
    GameObject[] _stage;

    GameObject[] _player;
        
    [SerializeField]
    [Header("ゴールステージのprefab")]
    GameObject _goalObject;

    [SerializeField]
    [Header("生成する背景のprefab")]
    GameObject _backscreen;

    [SerializeField]
    [Header("自動生成で足りない分の背景を追加する数")]
    int _addBackseason = 3;

   
    float _stageSpawninterval;
    

    float _backScreenSpawnimterval;


    private void Start()
    {
        Instantiate(GameManager.instance.Playes[GameManager.instance.PlayerSkinNumber], new Vector2(-15f, -3.3f), transform.rotation);
        Instantiate(GameManager.instance.Enemy[GameManager.instance.EnemySkinNumder], new Vector2(-25f, -3.4f), transform.rotation);
        if (GameManager.instance.IsFreeLevel)
        {
            GameManager.instance.StageCountSet(GameManager.instance.FreeLevel);
        }
        BackScreenSpawn();
        StageSpawn();
    }

    /// <summary>
    /// ステージを生成する処理
    /// </summary>
    public void StageSpawn()
    {
        _stageSpawninterval = 0;
        for (int i = 0; i < GameManager.instance.StageCount; i++)
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
        if (GameManager.instance.StageCount > 4)
        {
            _addBackseason += GameManager.instance.StageCount / 4;
        }
        Debug.Log("出たよ");
        _backScreenSpawnimterval = (float)-14.5;
        
        for (int i = 0; i < GameManager.instance.StageCount + _addBackseason; i++)
        {
            Instantiate(_backscreen, new Vector3(_backScreenSpawnimterval, 0f, 10f), transform.rotation);
            _backScreenSpawnimterval += (float)14.5;
        }
    }
}
