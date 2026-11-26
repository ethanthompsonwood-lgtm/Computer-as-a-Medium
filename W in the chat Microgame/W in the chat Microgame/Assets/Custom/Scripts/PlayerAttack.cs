using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    
    public GameObject bulletPrefab;
    public Transform firePoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void Attack()
    {
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            Shoot();
        }
        else
        {
            
        }
    }

    void Shoot()
    { 
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
