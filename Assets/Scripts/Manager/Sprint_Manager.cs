using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint_Manager : MonoBehaviour
{
    private PlayerSprint PS;

    private void Start()
    {
        PS = GameObject.Find("Player").GetComponent<PlayerSprint>();
    }
    
    private void FixedUpdate()
    {
        if (Player.instance.sprint)
        {
            PS.Sprint();
        }
    }
}
