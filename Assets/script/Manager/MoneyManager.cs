using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveData
{
    public int Money;
}

public class MoneyManager:SingletonMonoBehaviour<MoneyManager>
{
    public int Money => _money;

    [SerializeField]
    private int _money = 0;

    [SerializeField]
    private string _filePath;

    [SerializeField]
    SaveData _saveData;

    private void Awake()
    {
        _filePath = Application.persistentDataPath + "/" + ".savedata.json";
    }

    public void MoneyUp(int addMoney)
    {
        _money += addMoney;
    }

    public void MoneyDown(int downMoney)
    {
        _money -= downMoney+1;
    }

    public void Save()
    {
        string Json = JsonUtility.ToJson(_saveData);
    }
}
