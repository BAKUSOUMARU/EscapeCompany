using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// player�֘A��script
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Header("player�̓������x")]
    float _Speed = 5f;

    [SerializeField]
    [Header("player�̃W�����v��")]
    float _jump = 2f;

    [SerializeField] bool _isGround = false;
    
    Rigidbody2D _rd;
    Animator _anim;
    SpriteRenderer _sp;
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _sp = GetComponent<SpriteRenderer>();
        
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

       ///if (collision.gameObject.tag == "Object")
        ///{
            ///_isGround = true;
        ///}
        if (collision.gameObject.tag == "Goal")
        {
            GameManager.instance.GameClear();
            GameManager.instance._EnemyStop = true;
        }

    }

    
    /// <summary>
    /// player����������
    /// </summary>
    public void Move() 
    {
        float HorizontalKey = Input.GetAxis("Horizontal");
        float JumpKey = Input.GetAxis("Jump");
        Debug.Log(_isGround);
        if (!GameManager.instance._playerStop)
        {
            if (HorizontalKey > 0)
            {
                _rd.velocity = new Vector2(HorizontalKey * _Speed, _rd.velocity.y);
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
                _rd.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
                _isGround = false;
            }
        }
        else
        {
            _anim.SetBool("run", false);
        }
    }
}