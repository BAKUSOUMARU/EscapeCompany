using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// player関連のscript
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Header("playerの動く速度")]
    float _Speed = 5f;

    [SerializeField]
    [Header("playerのジャンプ力")]
    float _jump = 2f;

    [Header("地面を判定するフラグ")]
    bool _isGround = false;
    
    Rigidbody2D _rd;
    Animator _anim;
    SpriteRenderer _sp;
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _sp = GetComponent<SpriteRenderer>();
        GameManager.instance.playerStop = true;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGround = true;
        }
        if (collision.gameObject.tag == "Goal")
        {
            GameManager.instance.GameClear();
            GameManager.instance.enemyStop = true;
        }

    }

    /// <summary>
    /// playerが動く処理
    /// </summary>
    public void Move() 
    {
        float HorizontalKey = Input.GetAxis("Horizontal");
        float JumpKey = Input.GetAxis("Jump");
        Debug.Log(_isGround);
        if (!GameManager.instance.playerStop)
        {
            if (HorizontalKey > 0)
            {
                _rd.velocity =new Vector2(HorizontalKey * _Speed, _rd.velocity.y);
                _anim.SetBool("run", true);
                _sp.flipX = false;
            }
            else if (HorizontalKey < 0)
            {
                _rd.velocity = new Vector2(HorizontalKey * _Speed, _rd.velocity.y);
                _anim.SetBool("run", true);
                _sp.flipX = true;
            }
            else
            {
                _rd.velocity = Vector2.zero;
                _anim.SetBool("run", false);
            }   

            if (JumpKey > 0 && _isGround)
            {
                _rd.AddForce(_rd.velocity = new Vector2(_rd.velocity.x, JumpKey * _jump));
                //_rd.AddForce(Vector2.up * _jump,ForceMode2D.Impulse);
                _isGround = false;
            }
        }
        else
        {
            _anim.SetBool("run", false);
        }
    }
}