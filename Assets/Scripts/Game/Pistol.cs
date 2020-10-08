using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public float swap = 2;
    public string gunName; // 총의 이름.
    public float accuracy; // 정확도
    public float fireRate; // 연사속도.
    public float reloadTime; // 재장전 속도.

    public int damage; // 총의 데미지.

    public int reloadBulletCount; // 총알 재정전 개수.
    public int carryBulletCount; // 현재 소유하고 있는 총알 개수.
     
    public ParticleSystem muzzleFlash;

    public AudioClip fire_Sound;
}
