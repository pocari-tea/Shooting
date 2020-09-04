using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private GameObject bulletFactory;
    [SerializeField] private GameObject firePosition;

    
    float shootTimer = 0;
    float shootDelay = 0.2f;
    
    void Update()
    {
        Vector3 playerPos = transform.position;
        Vector3 mousePos = Input.mousePosition;

        Vector3 target = Camera.main.ScreenToWorldPoint(mousePos);
        
        float angle = Mathf.Atan2(target.y - playerPos.y, target.x - playerPos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler (0f, 0f, angle - 90);

        if (shootTimer > shootDelay && Input.GetButton("Fire1"))
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePosition.transform.position;
            
            shootTimer = 0;
        }
        
        shootTimer += Time.deltaTime;
    }
}