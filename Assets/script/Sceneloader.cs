using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{
    [SerializeField] string _scene = default;
    [SerializeField] GameLoadModo _gameLoadModo;
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
                break;
            case GameLoadModo.Exit:
                UnityEditor.EditorApplication.isPlaying = false;
                Application.Quit();
                break;
        }

        
    }

    enum GameLoadModo
    {
        retry,
        NormalRoad,
        Exit
    }
   
}
