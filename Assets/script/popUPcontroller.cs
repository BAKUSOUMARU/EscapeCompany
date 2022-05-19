using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUPcontroller : MonoBehaviour
{
    public GameObject _popup;
   
    public void PopUp()
    {
        _popup.SetActive(false);
    }
}
