using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpControllers : MonoBehaviour
{
    [Header("0�ȉ��̐������͂��ꂽ���ɏo���|�b�v�A�b�v")]
    public GameObject _popup;
   
    public void PopUp()
    {
        _popup.SetActive(false);
    }
}
