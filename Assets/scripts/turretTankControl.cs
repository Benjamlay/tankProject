using UnityEngine;
using UnityEngine.InputSystem;

public class turretTankControl : MonoBehaviour
{
    
    [SerializeField] private float fireRate = 0.5f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float _turnSpeed;

    private float _spinInput = 0f;
    private Rigidbody _rigidbody;
    private Coroutine Shoot_Routine = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, _spinInput * _turnSpeed, 0);
    }

    void OnRotateTurret(InputValue value)
    {
        _spinInput = value.Get<float>();
    }
}
