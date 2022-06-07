using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// �Q�[�����Ɉ�������݂��Ȃ��Q�[���}�l�[�W���[
/// �Ɋւ���script
/// </summary>
public class GameManager : MonoBehaviour
{
    [Header("�Q�[���X�^�[�g���Ă���̎���")]
    public float _timer = 0;

    [Header("Enemy���~�߂�̂����m����t���O")]
    public bool enemyStop = false;

    [Header("player���~�߂�̂����m����t���O")]
    public bool playerStop = false;

    [Header("freelevel���I���ɂ��邩")]
    public bool isfreelevel = false;

    [Header("��������X�e�[�W�̐�")]
    public int stagecount;

    [Header("�t���[���x���̃X�e�[�W���o����")]
    public int freelevel;

    [Header("�^�C�}�[���X�^�[�g������t���O")]
    public bool startTimer = false;

    public int money = 0;

    public static GameManager instance;

    public int skinnumber = 0;

    [SerializeField] Sprite[] _playersprite;

    public Sprite[] PlayerSprites => _playersprite; 
    /// <summary>
    ///�Q�[���}�l�[�W���[��scene���Ɉ�������݂���悤�ɂ��鏈��
    ///��DontDestroyOnLoad���Ăԏ���
    /// </summary>
    void Awake()
    {
        if (instance  == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }   

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
        money += stagecount; 
        playerStop = true;
        SceneManager.LoadScene("GameClear");
    }
}
