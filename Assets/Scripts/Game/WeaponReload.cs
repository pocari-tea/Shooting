using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponReload : Weapon
{
    public void reload()
    {
        StartCoroutine(reloadCoroutine());
    }
    
    IEnumerator reloadCoroutine()
    {
        // 2초 재장전 시간
        yield return new WaitForSeconds(intance.reloadTime);
        // 가지고 있는 총알수가 max총알 수 보다 작다면
        if (intance.haveBulletCount < intance.maxBulletCount)
        {
            // 장전되어있는 탄창에 탄을 넣고(더해주고) 총알수는 0으로
            intance.currentBulletCount = intance.haveBulletCount;
            intance.haveBulletCount = 0;
        }
        // 아닐때는 평범한 재장전
        else
        {
            intance.haveBulletCount -= (intance.maxBulletCount - intance.currentBulletCount);
            intance.currentBulletCount = intance.maxBulletCount;
        }
    }
}
