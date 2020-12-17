using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviourPunCallbacks, IPunObservable
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

    public PhotonView PV;

    private void Awake()
    {
        instance = this;
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        throw new NotImplementedException();
    }
}
