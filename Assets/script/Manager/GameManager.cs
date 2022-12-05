using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// �Q�[�����Ɉ�������݂��Ȃ��Q�[���}�l�[�W���[
/// �Ɋւ���script
/// </summary>
public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public float Timer => _timer;

    public GameStartFlagManager GameStartFlagManager => _gameStartFlagManager;
 
    [Header("�Q�[���X�^�[�g���Ă���̎���")]
    private float _timer = 0;

    GameStartFlagManager _gameStartFlagManager = new GameStartFlagManager();

    /// <summary>
    /// �Q�[���I�[�o�[�̏���
    /// </summary>
    public void GameOver()
    {
        Debug.Log("�Q�[���I��");
        SceneManager.LoadScene("GameOver");
    }
    /// <summary>
    /// �Q�[���N���A�̏���
    /// </summary>
    public void GameClear()
    {
        MoneyManager.Instance.MoneyUp(StageManager.Instance.StageCount * 2); 
        _gameStartFlagManager.StartPlayer();
        SceneManager.LoadScene("GameClear");
    }

    public void GameReset()
    {
       TimeReset();
       _gameStartFlagManager.StopEnemy();
       _gameStartFlagManager.StopPlayer();
    }

    public void TimerUp()
    {
        _timer += Time.deltaTime;
    }

    public void TimeReset()
    {
        _timer = 0;
    }
}
