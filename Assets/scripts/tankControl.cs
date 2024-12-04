using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class tankControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    [SerializeField] private float _turnSpeed;
    [SerializeField] private float _speed;

    private float _speed_input;
    
    
    private float _spinInput = 0f;
    private Rigidbody _rigidbody;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.AddForce(transform.forward * (_speed_input * _speed));
        _rigidbody.AddRelativeTorque(0, _spinInput * _turnSpeed, 0);
    }

    void OnRotateLeftRight(InputValue value)
    {
        _spinInput = value.Get<float>();
    }
    
    void OnMoveFrontBack(InputValue value)
    {
        _speed_input = value.Get<float>();
    }
    
}
