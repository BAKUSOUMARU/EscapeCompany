using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gamefinishcontroller : MonoBehaviour
{
    [SerializeField] Text _timertext;
    Gamefinishmode gamefinishmode;
    // Start is called before the first frame update
    void Start()
    {
        switch (gamefinishmode)
        {
            case Gamefinishmode.GameOver:
                _timertext.text = GameManager.instance._timer.ToString("F2");
                break;
            case Gamefinishmode.GameClear:
                _timertext.text = GameManager.instance._timer.ToString("F2");
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    enum Gamefinishmode
    {
        GameOver,
        GameClear
    }
}
