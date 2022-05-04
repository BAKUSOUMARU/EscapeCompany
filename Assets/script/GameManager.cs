using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField] Text _gameText;
    
    public bool _gameFlag = false;
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
    private void Update()
    {
        GaneOver();
    }


    public void GaneOver()
    {
        if (_gameFlag)
        {
            Debug.Log("ÉQÅ[ÉÄèIóπ");
            _gameText.gameObject.SetActive(true);
        }
    }
}
