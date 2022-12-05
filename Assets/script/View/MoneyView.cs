using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyView : MonoBehaviour
{
    [SerializeField] Text _moneyText;
    public void ChangeMoneyText(int money)
    {
        _moneyText.text = "所持金"+money.ToString() + "円";
    }
}
