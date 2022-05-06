using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timercontroller : MonoBehaviour
{
    [SerializeField] Text _scoreText;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Timer();
    }
    public void Timer()
    {
        if (!GameManager.instance._stoptimer)
        {
            GameManager.instance._timer += Time.deltaTime;
            _scoreText.text = GameManager.instance._timer.ToString("F2");
        }

    }
}
