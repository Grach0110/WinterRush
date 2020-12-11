using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Script : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Animator animator;
    private Rigidbody2D rigidBody2D;
    private float strike = 2f;
    private bool moveUp = false;

    private bool _moveHorizontal = false;
    float moveHorizontal;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rigidBody2D = GetComponent<Rigidbody2D>();

        rigidBody2D.gravityScale = 0.1f;
        gameObject.transform.position = new Vector3(0.5f, -1f, 0f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveUp = true;
        }
        if (Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.D)))
        {
            _moveHorizontal = true;
        }
    }

    private void FixedUpdate()
    {
        if (rigidBody2D.velocity.x > 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }

        if (moveUp)
        {
            MoveUp();
        }

        if (_moveHorizontal)
        {
            MoveHor();
        }
    }

    public void MoveUp()
    {
        rigidBody2D.AddForce(new Vector2(0, strike), ForceMode2D.Impulse);
        animator.SetTrigger("_Walk");
        moveUp = false;
    }

    public void MoveHor()
    {
        moveHorizontal = Input.GetAxis("Horizontal") * 10;
        rigidBody2D.AddForce(new Vector2(moveHorizontal, 1f), ForceMode2D.Impulse);
        animator.SetTrigger("_Walk");
        _moveHorizontal = false;
    }
}