using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim_Manager : MonoBehaviour
{
    private PlayerAim PA;
    private Aimstick astick;

    private void Start()
    {
        PA = GameObject.Find("Player").GetComponent<PlayerAim>();
        astick = GameObject.Find("AimBack").GetComponent<Aimstick>();
    }

    private void FixedUpdate()
    {
        PA.aimPlayer(astick.offset);
    }
}
