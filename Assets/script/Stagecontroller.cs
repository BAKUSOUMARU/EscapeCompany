using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ステージの自動生成のscript
/// </summary>
public class StageController : MonoBehaviour
{
    [SerializeField]
    [Header("生成するステージのprefab")]
    GameObject[] _stage;
        
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
        Instantiate(SkinManager.Instance.PlayerSkinList[SkinManager.Instance.NowPlayerSkinNumber].Player, new Vector2(-15f, -3.3f), transform.rotation);
        Instantiate(SkinManager.Instance.EnemySkinList[SkinManager.Instance.NowEnemySkinNumber].Enemy, new Vector2(-25f, -3.4f), transform.rotation);
        if (StageManager.Instance.IsFreeLevel)
        {
            StageManager.Instance.StageCountSet(StageManager.Instance.FreeLevel);
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
        for (int i = 0; i < StageManager.Instance.StageCount; i++)
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
        if (StageManager.Instance.StageCount > 4)
        {
            _addBackseason += StageManager.Instance.StageCount / 4;
        }
        Debug.Log("出たよ");
        _backScreenSpawnimterval = (float)-14.5;
        
        for (int i = 0; i < StageManager.Instance.StageCount + _addBackseason; i++)
        {
            Instantiate(_backscreen, new Vector3(_backScreenSpawnimterval, 0f, 10f), transform.rotation);
            _backScreenSpawnimterval += (float)14.5;
        }
    }
}
