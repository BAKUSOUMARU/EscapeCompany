using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class loadingText : MonoBehaviour
{
    [SerializeField] 
    [Header("NowLoadingを表示させるText")]
    Text _loadingText;
    

    private void Start()
    {
        _loadingText.DOText("NowLoading...", 2).SetEase(Ease.Linear)
            .SetLoops(-1,LoopType.Restart);
    }    
}
