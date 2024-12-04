using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class CanonControl : MonoBehaviour
{
    [SerializeField] private float fireRate = 0.5f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float _UpDownSpeed;
    
    private Coroutine Shoot_Routine = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnUpDownCanon(InputValue value)
    {
        _UpDownSpeed = value.Get<float>();
    }
    
    IEnumerator Fire()
    {
        while(true)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            yield return new WaitForSeconds(fireRate);
        } 
    }

    void OnShoot(InputValue value)
    {
        if (value.isPressed)
        {
            if (Shoot_Routine != null)
            {
                StopCoroutine(Shoot_Routine);
            }
            Shoot_Routine = StartCoroutine("Fire");
        }
        else
        {
            StopCoroutine("Fire");
            Shoot_Routine = null;
        }
    }
}
