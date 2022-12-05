using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : SingletonMonoBehaviour<StageManager>
{
    public int FreeLevel => _freeLevel;
    public int StageCount => _stageCount;
    public bool IsFreeLevel => isFreeLevel;
   
    [Header("生成するステージの数")]
    private int _stageCount;

    [Header("フリーレベルのステージを出す数")]
    private int _freeLevel;

    [Header("freelevelをオンにするか")]
    private bool isFreeLevel = false;

    public void StageCountSet(int setCount)
    {
        _stageCount = setCount;
    }

    public void FreeStageCountSet(int setCount)
    {
        _freeLevel = setCount;
    }

    public void FreeLevelOn()
    {
        isFreeLevel = true;
    }

    public void FreeLevelOff()
    {
        isFreeLevel = false;
    }

}
