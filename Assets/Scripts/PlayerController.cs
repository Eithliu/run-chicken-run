using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private bool _isRunning;
    private float _movementDirection = 0;
    private NewPlayerController _moveAction;
    private Rigidbody2D _playerRigidbody;
    private Animator _animator;
    private Vector2 position = new Vector2(0, -3.8f);
    public SpriteRenderer spriteRenderer;
    public GarbageManager garbage;

    private void Start()
    {
        _playerRigidbody ??= GetComponent<Rigidbody2D>();
        _moveAction = new NewPlayerController();
        _moveAction.Enable();
        _moveAction.horizontal.Move.performed += moving =>
        {
            _movementDirection = moving.ReadValue<float>();
        };
    }
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Init()
    {
        _isRunning = false;
    }

    void Update()
    {
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            if (Keyboard.current.rightArrowKey.isPressed)
            {
                spriteRenderer.flipX = false;
            }
            else 
            {
                spriteRenderer.flipX = true;
            }
            _isRunning = true;
            _animator.SetBool("isRunning", _isRunning);
            _playerRigidbody.linearVelocity = new Vector2(_movementDirection * speed, 0);
        }
        else 
        {
            _isRunning = false;
            _animator.SetBool("isRunning", _isRunning);
            _playerRigidbody.linearVelocity = new Vector2(0,0);
        }
    }

    public void Spawn()
    {
        transform.position = position;
    }
}
