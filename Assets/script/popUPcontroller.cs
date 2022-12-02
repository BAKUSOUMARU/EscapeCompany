using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpControllers : MonoBehaviour
{
    [Header("0以下の数が入力された時に出すポップアップ")]
    public GameObject _popup;
   
    public void PopUp()
    {
        _popup.SetActive(false);
    }
}
