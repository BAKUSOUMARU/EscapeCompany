using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCheck : MonoBehaviour
{
    [SerializeField] Text _text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "èäéùã‡"+MoneyManager.Instance.Money.ToString() + "â~";
    }
}
