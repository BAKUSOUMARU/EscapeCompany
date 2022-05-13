using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class loadingText : MonoBehaviour
{
    [SerializeField] Text _loadingText;
    // Update is called once per frame

    private void Start()
    {
        _loadingText.DOText("NowLoading...", 2).SetEase(Ease.Linear)
            .SetLoops(-1,LoopType.Restart);
    }    
}
