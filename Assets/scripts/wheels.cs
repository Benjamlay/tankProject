using UnityEngine;
using UnityEngine.InputSystem;

public class wheels : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _speed_input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_speed * _speed_input, 0, 0);
    }

    void OnMoveFrontBack(InputValue value)
    {
        _speed_input = value.Get<float>();
    }
}
