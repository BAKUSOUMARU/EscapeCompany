using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Enemy��script
/// </summary>
public class EnemyController : MonoBehaviour
{
    [SerializeField]
    [Header("�ړ�����")]
    Vector2 _dir;

    [SerializeField]
    [Header("�ړ����x")]
    float _speed = 2;

    Rigidbody2D _rd;
    Animator _anim;
   
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        GameManager.Instance.GameStartFlagManager.StopEnemy();
    }

    void FixedUpdate()
    {
        EnemyMove();
    }

    /// <summary>
    /// Enemy�̓����̏���
    /// </summary>
    void EnemyMove()
    {
        if (GameManager.Instance.GameStartFlagManager.IsEnemyMove)
        {
            _rd.velocity = _dir.normalized * _speed;
        }
        else
        {
            _rd.velocity = _dir.normalized * 0;
            _anim.SetBool("Move", false);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Object"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance.GameOver(); 
        }
    }
}
