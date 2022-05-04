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
    
    Rigidbody2D rd;
    Vector2 _dir;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
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

    }

    
    /// <summary>
    /// player����������
    /// </summary>
    public void Move() 
    {
        float HorizontalKey = Input.GetAxis("Horizontal");
        float JumpKey = Input.GetAxis("Jump");
        Debug.Log(_isGround);

            if (HorizontalKey > 0)
            {
                rd.velocity = new Vector2(HorizontalKey * _Speed, rd.velocity.y);
            }
            else
            {
                rd.velocity = Vector2.zero; 
            }

            if (JumpKey > 0 && _isGround)
            {
             rd.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
            _isGround = false;
            }
    }
}