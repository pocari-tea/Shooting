using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprint : Player
{
    public void Sprint()
    {
        if (instance.staminer > 0 && instance.sprint)
        {
            instance.staminer -= 1f;
            instance.speed = sprint_Speed;
        }
    }
}
