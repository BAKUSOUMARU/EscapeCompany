using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Enemyのscriptです
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

    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        EnemyMove();
    }
    void EnemyMove()
    {
        _rd.velocity = _dir.normalized * _speed;
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
            GameManager.instance._gameFlag = true;
        }

    }
}
