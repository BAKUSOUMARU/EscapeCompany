using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : SingletonMonoBehaviour<StageManager>
{
    public int FreeLevel => _freeLevel;
    public int StageCount => _stageCount;
    public bool IsFreeLevel => isFreeLevel;
   
    [Header("��������X�e�[�W�̐�")]
    private int _stageCount;

    [Header("�t���[���x���̃X�e�[�W���o����")]
    private int _freeLevel;

    [Header("freelevel���I���ɂ��邩")]
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
