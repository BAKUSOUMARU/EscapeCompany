using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
/// <summary>
/// ���[�h��ʂ̃e�L�X�g��script
/// </summary>
public class LoadingText : MonoBehaviour
{
    [SerializeField] 
    [Header("NowLoading��\��������Text")]
    Text _loadingText;
    

    private void Start()
    {
        _loadingText.DOText("NowLoading...", 2).SetEase(Ease.Linear)
            .SetLoops(-1,LoopType.Restart);
    }    
}
