using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Enemy‚Ìscript‚Å‚·
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
