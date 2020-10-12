using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Manager : MonoBehaviour
{
    private PlayerAttack PA;

    private void Start()
    {
        PA = GameObject.Find("Glock17").GetComponent<PlayerAttack>();
    }
    
    private void FixedUpdate()
    {
        if (Player.instance.attack)
        {
            PA.Fire();
        }
    }
}
