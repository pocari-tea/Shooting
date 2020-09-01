using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    
    void Update()
    {
        Vector3 dir = Input.mousePosition;

        // transform.Translate (0, transform.up, 0 * speed * Time.deltaTime);
    }
}
