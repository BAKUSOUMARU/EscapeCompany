using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartFlagManager 
{
    public bool IsEnemyMove => isEnemyMove;

    public bool IsPlayerMove => isPlayerMove;

    public bool IsStartTimer => isStartTimer;

    [Header("Enemy���~�߂�̂����m����t���O")]
    private static bool isEnemyMove = false;

    [Header("player���~�߂�̂����m����t���O")]
    private static bool isPlayerMove = false;

    [Header("�^�C�}�[���X�^�[�g������t���O")]
    private static bool isStartTimer = false;

    public void StartPlayer()
    {
        isPlayerMove = true;
    }

    public void StopPlayer()
    {
        isPlayerMove = false;
    }

    public void StartEnemy()
    {
        isEnemyMove = true;
    }

    public void StopEnemy()
    {
        isEnemyMove = false;
    }

    public void StartTimer()
    {
        isStartTimer = true;
    }

    public void StopTimer()
    {
        isStartTimer = false;
    }
}
