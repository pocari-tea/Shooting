using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : Player
{
    private Rigidbody2D rb;
    private Movestick mstick;

    private void Start()
    {
        rb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        mstick = GameObject.Find("MoveBack").GetComponent<Movestick>();
        
        instance.speed = walk_Speed;
        instance.staminer = maxStaminer;
    }

    public void MovePlayer(Vector2 direction)
    {
         // 달리기를 누르지 않으면 스태미너 회복
        if (instance.staminer <= 100)
        {
            instance.staminer += 0.2f;
        }

        if (!instance.sprint || instance.staminer <= 0)
        {
            instance.speed = walk_Speed;
        }
        
        Vector2 dir = new Vector2(direction.normalized.x * instance.speed, direction.normalized.y * instance.speed);

        rb.velocity = mstick.state ? dir : Vector2.zero;
    }
}
