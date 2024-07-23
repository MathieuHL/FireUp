using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100.0f;
    private float _currentHealth;

    [SerializeField] private float verticalSpeed = 5.0f, horizontalSpeed = 3.0f;
    private Rigidbody2D _rb;

    [SerializeField] private PlayerInput _playerInput;
    private float _inputPressed;
    private bool _isMove = false;

    void Start()
    {
        _currentHealth = _maxHealth;
        _rb = GetComponent<Rigidbody2D>();

        _playerInput.actions["Move"].performed += OnMovePerformed;
        _playerInput.actions["Move"].canceled += OnMoveCanceled;
    }

    void Update()
    {
        // Make the player go up
        _rb.AddForce(new Vector2(0, verticalSpeed * Time.deltaTime));

        if (_isMove)
        {
            transform.position += new Vector3(_inputPressed * horizontalSpeed * Time.deltaTime, 0, 0);
        }
    }

    public void OnMovePerformed(InputAction.CallbackContext context)
    {
        _isMove = true;
        _inputPressed = context.action.ReadValue<Vector2>().x;
    }
    
    public void OnMoveCanceled(InputAction.CallbackContext context)
    {
        _isMove = false;
    }
}