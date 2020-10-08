using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    private Rigidbody2D rb;
    
    private float currentFireRate;

    private void Start()
    {
        rb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        FireRateCal();
    }

    private void FireRateCal()
    {
        currentFireRate -= Time.deltaTime;
    }

    public void Fire()
    {
        if (currentFireRate < 0 && Weapon.intance.currentBulletCount > 0)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject temp = Instantiate(bullet);
        temp.transform.position = Weapon.intance.FirePosition.position;
        temp.transform.rotation = rb.transform.rotation;
        Weapon.intance.currentBulletCount--;
        
        currentFireRate = Weapon.intance.fireRate;
    }
}