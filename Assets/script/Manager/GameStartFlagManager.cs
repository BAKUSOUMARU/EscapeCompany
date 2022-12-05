using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartFlagManager 
{
    public bool IsEnemyMove => isEnemyMove;

    public bool IsPlayerMove => isPlayerMove;

    public bool IsStartTimer => isStartTimer;

    [Header("Enemyを止めるのを検知するフラグ")]
    private static bool isEnemyMove = false;

    [Header("playerを止めるのを検知するフラグ")]
    private static bool isPlayerMove = false;

    [Header("タイマーをスタートさせるフラグ")]
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
