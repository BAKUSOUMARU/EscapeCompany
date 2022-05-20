using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// シーンロードに関するscript
/// </summary>
public class Sceneloader : MonoBehaviour
{
    [SerializeField] 
    [Header("ロードするシーンの名前")]
    string _scene = default;
    
    [SerializeField]
    [Header("自動ロード時のロードする時間")]
    float _roadtime;

    [SerializeField]
    [Header("ゲームのロードのやり方")]
    GameLoadModo _gameLoadModo;
    
    [SerializeField]
    [Header("フリーレベルの入力されるText")]
    Text _inpottext;
    
    [SerializeField] 
    [Header("遷移される先の難易度の設定")]
    stagelevel _stagelevel;

    [SerializeField] GameObject _popup;
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
                GameManager.instance.freelevel = 0;
                break;
            
            case GameLoadModo.Exit:
                Application.Quit();
                break;
            
            case GameLoadModo.select:
                GameManager.instance._timer = 0;
                GameManager.instance.enemyStop = false;
                GameManager.instance.playerStop = false;
                
                switch (_stagelevel)
                {
                    case stagelevel.Normal:
                        GameManager.instance.stagecount = 20;
                        SceneManager.LoadScene(scene);
                        break;
                  
                    case stagelevel.hard:
                        GameManager.instance.stagecount = 40;
                        SceneManager.LoadScene(scene);
                        break;
                    
                    case stagelevel.freelevel:
                        if(int.Parse(_inpottext.text) > 0)
                        {
                            SceneManager.LoadScene(scene);
                            GameManager.instance.freelevel = int.Parse(_inpottext.text);
                            GameManager.instance.isfreelevel = true;
                        }
                        else
                        {
                           _popup.SetActive(true);   
                        }
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
