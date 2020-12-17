using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        StartGame();
    }
    
    void StartGame()
    {
        PhotonNetwork.Instantiate("Player", Vector2.zero, Quaternion.identity);
    }
}
