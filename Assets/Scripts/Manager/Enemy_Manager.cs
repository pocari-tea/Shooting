﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Manager : Enemy
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
         {
             if (other.gameObject.CompareTag("Bullet"))
             {
                 //hp -= Bullet.damage;
                 
                 if (hp <= 0)
                 {
                     Destroy(gameObject);
                 }
             }   
         }
         else
         {
             Debug.Log("_bullet Null!!");
         }
    }
}












































































































































































































































































































































































































































































































































































































