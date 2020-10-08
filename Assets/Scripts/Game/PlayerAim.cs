using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    private Rigidbody2D rb;
    // private Aimstick astick;

    private void Start()
    {
        rb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        // astick = GameObject.Find("AimBack").GetComponent<Aimstick>();
    }

    public void aimPlayer(Vector2 offset)
    {
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        rb.transform.rotation = Quaternion.Euler(0, 0, angle - 90);
    }
}
