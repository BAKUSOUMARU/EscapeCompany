using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageComtroller : MonoBehaviour
{
    [SerializeField] GameObject[] _stage;
    [SerializeField] GameObject _goalObject;
    [SerializeField] float _Spawninterval;


    // Update is called once per frame
    private void Start()
    {
        StageSpawn();
    }
    
    public void StageSpawn()
    {
        _Spawninterval = 0;
        for (int i = 0; i < _stage.Length; i++)
        {
            int randomIndex = Random.Range(0, _stage.Length);
            Instantiate(_stage[randomIndex], new Vector2(_Spawninterval, -5f), transform.rotation);
            _Spawninterval += 18f;
        }
         Instantiate(_goalObject, new Vector2(_Spawninterval, -5f), transform.rotation);
    }
}
