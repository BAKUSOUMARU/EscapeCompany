using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TimerPresenter : MonoBehaviour
{
    [SerializeField]
    TimerController _timerController;

    [SerializeField]
    TimerView _timerView;
    
    // Start is called before the first frame update
    void Start()
    {
        _timerController.ObserveEveryValueChanged(x => _timerController.StartCount)
            .Subscribe(x => _timerView.ChangeStartTimer(x)).AddTo(this);

        GameManager.instance.ObserveEveryValueChanged(x=> GameManager.instance.Timer)
            .Subscribe(x => _timerView.ChangeTimer(x)).AddTo(this);
    }
}
