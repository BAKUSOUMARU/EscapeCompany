using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sceneloader : MonoBehaviour
{
    [SerializeField] 
    string _scene = default;
    
    [SerializeField]
    GameLoadModo _gameLoadModo;
    
    [SerializeField]
    Text _inpottext;
    
    [SerializeField] 
    stagelevel _stagelevel;
    
    [SerializeField]
    float _roadtime;

    private void Update()
    {
        if (_gameLoadModo != GameLoadModo.Autoroad) return;
        _roadtime -= Time.deltaTime;
        if (_roadtime < 0 )
        {
            SceneManager.LoadScene(_scene);
        }
    }

    public void Sceneroad(string scene)
    {
        switch (_gameLoadModo)
        {
            
            case GameLoadModo.retry:
                SceneManager.LoadScene(scene);
                GameManager.instance._timer = 0;
                GameManager.instance.enemyStop = false;
                GameManager.instance.playerStop = false;
                break;

            case GameLoadModo.normalroad:
                SceneManager.LoadScene(scene);
                break;
            
            case GameLoadModo.titlelRoad:
                SceneManager.LoadScene(scene);
                GameManager.instance.isfreelevel = false;
                break;
            
            case GameLoadModo.Exit:
               // UnityEditor.EditorApplication.isPlaying = false;
                Application.Quit();
                break;
            
            case GameLoadModo.select:
                SceneManager.LoadScene(scene);
                GameManager.instance._timer = 0;
                GameManager.instance.enemyStop = false;
                GameManager.instance.playerStop = false;
                
                switch (_stagelevel)
                {
                    case stagelevel.Normal:
                        GameManager.instance.stagecount = 20;
                        break;
                  
                    case stagelevel.hard:
                        GameManager.instance.stagecount = 40;
                        break;
                    
                    case stagelevel.freelevel:
                        GameManager.instance.isfreelevel = true;
                        GameManager.instance.freelevel = int.Parse(_inpottext.text);
                        break;
                }
                break;
        }                
    }

    enum GameLoadModo
    {
        retry,
        normalroad,
        titlelRoad,
        Exit,
        select,
        Autoroad
    }
    enum stagelevel
    {
        Normal,
        hard,
        freelevel
    }
}
