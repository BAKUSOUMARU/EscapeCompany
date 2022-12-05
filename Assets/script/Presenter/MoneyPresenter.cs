using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class MoneyPresenter : MonoBehaviour
{
    [SerializeField]
    MoneyView _moneyView;

    private void Start()
    {
        MoneyManager.Instance.ObserveEveryValueChanged(x => MoneyManager.Instance.Money)
            .Subscribe(x => _moneyView.ChangeMoneyText(x)).AddTo(this); 
    }
}
