using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// �V�[�����[�h�Ɋւ���script
/// </summary>
public class SceneLoader : SceneLoad
{
    [SerializeField] 
    [Header("���[�h����V�[���̖��O")]
    string _scene = default;
    
    [SerializeField]
    [Header("�������[�h���̃��[�h���鎞��")]
    float _roadtime;

    [SerializeField]
    [Header("�Q�[���̃��[�h�̂���")]
    GameLoadModo _gameLoadModo;
    
    [SerializeField]
    [Header("�t���[���x���̓��͂����Text")]
    Text _inpotText;
    
    [SerializeField] 
    [Header("�J�ڂ�����̓�Փx�̐ݒ�")]
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
