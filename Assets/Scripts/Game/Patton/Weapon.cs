using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public static Weapon intance;
    
    public string Name; // 총의 이름.
    public float accuracy; // 정확도
    public float fireRate; // 연사속도.
    public float reloadTime; // 재장전 속도.

    public int damage; // 총의 데미지.

    public int maxBulletCount; // 총알 재정전 개수.
    public int currentBulletCount; // 장전되어 있는 총알 개수.
    public int haveBulletCount; // 가지고 있는 총알 개수
     
    public ParticleSystem muzzleFlash;

    public AudioClip fire_Sound;

    public Transform FirePosition;

    private void Awake()
    {
        intance = this;
    }
}
