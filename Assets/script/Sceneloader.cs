using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sceneloader : MonoBehaviour
{
    [SerializeField] string _scene = default;
    [SerializeField] GameLoadModo _gameLoadModo;
    [SerializeField]
    public Text _inpottext;
    [SerializeField] stagelevel _stagelevel;
    public void Seasonroad(string scene)
    {
        switch (_gameLoadModo)
        {
            
            case GameLoadModo.retry:
                SceneManager.LoadScene(scene);
                GameManager.instance._timer = 0;
                GameManager.instance._EnemyStop = false;
                GameManager.instance._playerStop = false;
                GameManager.instance._stoptimer = false;
                break;
            
            case GameLoadModo.NormalRoad:
                SceneManager.LoadScene(scene);
                GameManager.instance._isfreelevel = false;
                break;
            
            case GameLoadModo.Exit:
                UnityEditor.EditorApplication.isPlaying = false;
                Application.Quit();
                break;
            
            case GameLoadModo.select:
                SceneManager.LoadScene(scene);
                GameManager.instance._timer = 0;
                GameManager.instance._EnemyStop = false;
                GameManager.instance._playerStop = false;
                GameManager.instance._stoptimer = false;
                
                switch (_stagelevel)
                {
                    case stagelevel.Normal:
                        GameManager.instance._stagecount = 20;
                        break;
                    case stagelevel.hard:
                        GameManager.instance._stagecount = 40;
                        break;
                    case stagelevel.freelevel:
                        GameManager.instance._isfreelevel = true;
                        GameManager.instance._freelevel = int.Parse(_inpottext.text);
                        break;
                }
                break;
        }                
    }

    enum GameLoadModo
    {
        retry,
        NormalRoad,
        Exit,
        select
    }
    enum stagelevel
    {
        Normal,
        hard,
        freelevel
    }
   
}
