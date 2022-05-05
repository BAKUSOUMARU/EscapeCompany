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
    public float _speed = 2;


    Rigidbody2D _rd;
    Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
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
        if (!GameManager.instance._EnemyStop)
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
