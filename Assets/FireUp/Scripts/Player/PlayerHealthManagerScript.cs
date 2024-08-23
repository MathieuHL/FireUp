using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManagerScript : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100.0f;
    private float _currentHealth;
    [SerializeField]private float _lostHealth = -1.0f;
    
    void Start()
    {
        
        _currentHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        // Decrease Player Health over time
        UpdatePlayerHealth(_lostHealth);
    }
    
    public float GetLifePlayer()
    {
        return _currentHealth;
    }

    void UpdatePlayerHealth(float newValue)
    {
        _currentHealth += newValue*Time.deltaTime;
    }
}
