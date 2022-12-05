using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
/// <summary>
/// ロード画面のテキストのscript
/// </summary>
public class LoadingText : MonoBehaviour
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
