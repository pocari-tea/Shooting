using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float walk_Speed;
    private float sprint_Speed;

    private void Start()
    {
        walk_Speed = 5f;
        sprint_Speed = 10f;
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0);
        //transform.position = transform.position + dir * speed * Time.deltaTime; ==

        if (Input.GetKey(KeyCode.LeftShift))
        {
            walk_Speed = sprint_Speed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            walk_Speed = 5f;
        }

        transform.position += dir * walk_Speed * Time.deltaTime;
    }
}
