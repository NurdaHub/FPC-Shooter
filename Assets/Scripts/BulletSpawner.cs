using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private BulletController bulletPrefab;
    private Pool<BulletController> bulletsPool;
    private int defaultBulletsCount = 10;

    private void Start()
    {
        bulletsPool = new Pool<BulletController>(bulletPrefab, defaultBulletsCount, transform);
    }

    public void Spawn()
    {
        var bullet = bulletsPool.GetFreeElement();
        bullet.InitBullet(transform.position, transform.rotation);
    }
}
