using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveData
{
    public int money;

    public string[] playerSkinBuyCheck;

    public string[] enemySkinBuyCheck;
}

public class SaveDataManager:SingletonMonoBehaviour<SaveDataManager>
{
    public int Money => _saveData.money;


    [SerializeField]
    private string _filePath;

    [SerializeField]
    SaveData _saveData;

    protected override void Awake()
    {
        base.Awake();
        _filePath = Application.persistentDataPath + "/" + ".savedata.json";
        Load();
        PlayerSkinBuy(0);
        EnemySkinBuy(0);
    }

    public void MoneyUp(int addMoney)
    {
        _saveData.money += addMoney;
        Save();
    }

    public void MoneyDown(int downMoney)
    {
        _saveData.money -= downMoney+1;
        Save();
    }

    public void Save()
    {
        if (!File.Exists(_filePath))
        {
            _filePath = Application.persistentDataPath + "/" + ".savedata.json"; 
        }
        else
        {
        }
        
            string json = JsonUtility.ToJson(_saveData);
            StreamWriter streamWriter = new StreamWriter(_filePath);
            streamWriter.Write(json); streamWriter.Flush();
            streamWriter.Close();
    }

    public void Load()
    {
        if (File.Exists(_filePath))
        {
            StreamReader streamReader;
            streamReader = new StreamReader(_filePath);
            string _data = streamReader.ReadToEnd();
            streamReader.Close();

            _saveData = JsonUtility.FromJson<SaveData>(_data);
        }
    }

    public void RestSaveData()
    {
        _saveData.money = 0;
        _saveData.playerSkinBuyCheck = new string[7];
        _saveData.enemySkinBuyCheck = new string[3];
        Save();
    }

    public bool PlayerSkinCheck(int CheckNumber)
    {
        bool returnCheck = false;
        if (_saveData.playerSkinBuyCheck[CheckNumber]== "true")
        {
            returnCheck = true;
        }
        return returnCheck;
    }

    public bool EnemySkintCheck(int CheckNumber)
    {
        bool returnCheck = false;
        if (_saveData.enemySkinBuyCheck[CheckNumber] == "true")
        {
            returnCheck = true;
        }
        return returnCheck;
    }

    public void PlayerSkinBuy(int buySkinNumber)
    {
        _saveData.playerSkinBuyCheck[buySkinNumber] = "true";
    }

    public void EnemySkinBuy(int buySkinNumber)
    {
        _saveData.enemySkinBuyCheck[buySkinNumber] = "true";
    }
}
