using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float _maxHealth = 100.0f;
    private float _currentHealth;

    private int moveMultiplicator = 100;

    [SerializeField]
    private float speed=5.0f;

    private Rigidbody2D _rb;
    private PlayerInput _playerInput;
    
    void Start()
    {
        _currentHealth = _maxHealth;
        _rb = GetComponent<Rigidbody2D>();
        
        // Manage Inputs
        _playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        _rb.AddForce(new Vector2(0, speed*Time.deltaTime));
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.action.ReadValue<Vector2>().x > 0)
        {
            _rb.AddForce(new Vector2((moveMultiplicator+speed), 0));
        }
        else if (context.action.ReadValue<Vector2>().x < 0)
        {
            _rb.AddForce(new Vector2(-(moveMultiplicator+speed), 0));
        }
    }
}
