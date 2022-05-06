using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stagecontroller : MonoBehaviour
{
    [SerializeField] GameObject[] _stage;
    [SerializeField] int _stagecount;
    [SerializeField] GameObject _goalObject;
    private float _stageSpawninterval;
    private float _backScreenSpawnimterval;
    [SerializeField] GameObject _backscreen;

    int _addBackseason = 3;
    // Start is called before the first frame update
    private void Start()
    {

        if (_stagecount / 5 > 0)
        {
            _addBackseason += _stagecount / 4;
        }
        Debug.Log(_addBackseason);
        BackScreenSpawn();
        StageSpawn();
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
        Debug.Log("o‚½‚æ");
        _backScreenSpawnimterval = (float)-14.5;
        for (int i = 0; i < _stagecount + _addBackseason; i++)
        {
            Instantiate(_backscreen, new Vector3(_backScreenSpawnimterval, 0f, 10f), transform.rotation);
            _backScreenSpawnimterval += (float)14.5;
        }
    }
}
