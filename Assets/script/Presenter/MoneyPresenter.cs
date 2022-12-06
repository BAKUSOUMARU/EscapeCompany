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
        SaveDataManager.Instance.ObserveEveryValueChanged(x => SaveDataManager.Instance.Money)
            .Subscribe(x => _moneyView.ChangeMoneyText(x)).AddTo(this); 
    }
}
