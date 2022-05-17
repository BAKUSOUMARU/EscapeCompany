using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Enemy‚Ìscript
/// </summary>
public class EnemyController : MonoBehaviour
{
    [SerializeField]
    [Header("ˆÚ“®•ûŒü")]
    Vector2 _dir;

    [SerializeField]
    [Header("ˆÚ“®‘¬“x")]
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
    /// Enemy‚Ì“®‚«‚Ìˆ—
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
