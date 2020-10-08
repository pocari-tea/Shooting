using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player instance;
    
    public float maxHP = 100f;
    public float maxStaminer = 100f;
    public float walk_Speed = 5f;
    public float sprint_Speed = 10f;

    public float hp;
    public float staminer;
    public float speed;
    public int swap; 

    public bool sprint;
    public bool attack;

    private void Awake()
    {
        instance = this;
    }
}
