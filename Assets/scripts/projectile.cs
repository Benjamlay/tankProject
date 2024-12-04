using System;
using UnityEngine;

public class projectile : MonoBehaviour
{
    
    [SerializeField] private float bulletforce = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody>().linearVelocity = transform.forward * bulletforce;
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("collision Enter ???" + other.gameObject.name);

        if (other.collider.CompareTag("destructible"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.TryGetComponent(out destructible objective))
        {
            objective.TakeDamage(5);
        }
    }
    
    private void OnCollisionStay(Collision other)
    {
        throw new NotImplementedException();
    }
    
    private void OnCollisionExit(Collision other)
    {
        throw new NotImplementedException();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        throw new NotImplementedException();
    }
}
