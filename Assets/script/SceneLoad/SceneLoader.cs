using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// シーンロードに関するscript
/// </summary>
public class SceneLoader : SceneLoad
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
    Text _inpotText;
    
    [SerializeField] 
    [Header("遷移される先の難易度の設定")]
    StageLevel _stagelevel;

    [SerializeField] GameObject _popup;
    private void Update()
    {
        if (_gameLoadModo != GameLoadModo.Autoroad) return;
        _roadtime -= Time.deltaTime;
        if (_roadtime < 0 )
        {
            LoadScene();
        }
    }

    public void Sceneroad()
    {
        switch (_gameLoadModo)
        {   
            case GameLoadModo.titlelRoad:
              //  SceneManager.LoadScene(_scene);
                GameManager.instance.isfreelevel = false;
                GameManager.instance.freelevel = 0;
                break;
            
            case GameLoadModo.Exit:
                Application.Quit();
                break;
            
            case GameLoadModo.select:
                GameManager.instance.GameReset();
                switch (_stagelevel)
                {
                    case StageLevel.Normal:
                        GameManager.instance.stagecount = 20;
                      //  SceneManager.LoadScene(_scene);
                        break;
                  
                    case StageLevel.hard:
                        GameManager.instance.stagecount = 40;
                      //  SceneManager.LoadScene(_scene);
                        break;
                    
                    case StageLevel.freelevel:
                        if(int.Parse(_inpotText.text) > 0)
                        {
                        //    SceneManager.LoadScene(_scene);
                            GameManager.instance.freelevel = int.Parse(_inpotText.text);
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
    
    enum StageLevel
    {
        Normal,
        hard,
        freelevel
    }
}
