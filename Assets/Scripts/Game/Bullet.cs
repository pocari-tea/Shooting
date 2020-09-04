using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 30;
    
    Vector3 playerPos;
    Vector3 mousePos;

    private void Start()
    {
        playerPos = transform.position;
        mousePos = Input.mousePosition;
        
        Vector3 target = Camera.main.ScreenToWorldPoint(mousePos);
        
        float angle = Mathf.Atan2(target.y - playerPos.y, target.x - playerPos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler (0f, 0f, angle - 90);
    }

    void Update()
    {
        transform.Translate (0f, speed * Time.deltaTime, 0f);
    }
    
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
