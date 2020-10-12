using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_Manager : MonoBehaviour
{
    private PlayerMove PM;
    private Movestick mstick;

    private void Start()
    {
        PM = GameObject.Find("Player").GetComponent<PlayerMove>();
        mstick = GameObject.Find("MoveBack").GetComponent<Movestick>();
    }

    private void FixedUpdate()
    {
        PM.MovePlayer(mstick.direction);
    }
}
