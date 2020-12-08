using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Script : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private float strike = 2f;
    private bool moveUp = false;

    private bool _moveHorizontal = false;
    float moveHorizontal;

    private void Start()
    {
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
        moveUp = false;
    }

    public void MoveHor()
    {
        moveHorizontal = Input.GetAxis("Horizontal") * 10;
        rigidBody2D.AddForce(new Vector2(moveHorizontal, 1f), ForceMode2D.Impulse);
        _moveHorizontal = false;
    }
}