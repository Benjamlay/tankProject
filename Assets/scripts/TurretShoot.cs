using System.Collections;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{
    
    
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;
    
    private Coroutine Shoot_Routine = null;
    public float fireInterval = 2f; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Fire());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator Fire()
    {
        while(true)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            yield return new WaitForSeconds(fireInterval);
        } 
    }
    
}
