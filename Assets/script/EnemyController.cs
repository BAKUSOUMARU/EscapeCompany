using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Enemyのscript
/// </summary>
public class EnemyController : MonoBehaviour
{
    [SerializeField]
    [Header("移動方向")]
    Vector2 _dir;

    [SerializeField]
    [Header("移動速度")]
    float _speed = 2;

    Rigidbody2D _rd;
    Animator _anim;
   
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        GameManager.instance.enemyStop = true;
    }

    void FixedUpdate()
    {
        EnemyMove();
    }
    /// <summary>
    /// Enemyの動きの処理
    /// </summary>
    void EnemyMove()
    {
        if (!GameManager.instance.enemyStop)
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
        if (collision.gameObject.tag == "Object")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameManager.instance.GameOver(); 
        }
    }
}
