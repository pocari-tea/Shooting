using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 30;
    
    Vector3 playerPos;
    Vector3 mousePos;

    void Update()
    {
        transform.Translate (Vector2.up * speed * Time.deltaTime, Space.Self);
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
    
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
