using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager:SingletonMonoBehaviour<MoneyManager>
{
    public int Money => _money;

    [SerializeField]
    private int _money = 0;


    public void MoneyUp(int addMoney)
    {
        _money += addMoney;
    }

     public void MoneyDown(int downMoney)
    {
        _money -= downMoney;
    }
}
