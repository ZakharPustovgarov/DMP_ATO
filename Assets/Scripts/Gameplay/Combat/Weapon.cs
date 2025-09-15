using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    protected float fireRate = 1f;
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private Bullet bulletPrefab;
    [SerializeField]
    private int bulletPoolSize = 10;
    [SerializeField]
    private float bulletReturnDelay = 1f;
    [SerializeField]
    private int damagePerShot = 1;

    private Queue<Bullet> bulletPool = new Queue<Bullet>();


    protected bool isCooldown = false;

    private void Start()
    {
        for (int i = 0; i < bulletPoolSize; i++)
        {
            Bullet bullet = Instantiate(bulletPrefab);
            bullet.gameObject.SetActive(false);
            bulletPool.Enqueue(bullet);
        }
    }

    public virtual void Shoot()
    {
        if (!CheckShootRestrictions()) return;

        FireBullet();

        StartCooldown();
    }

    protected virtual void FireBullet()
    {
        Bullet bullet = bulletPool.Dequeue();
        bullet.transform.position = firePoint.position;
        bullet.transform.rotation = firePoint.rotation;
        bullet.gameObject.SetActive(true);
        bullet.StartShot(damagePerShot);
        StartCoroutine(ReturnBulletToPool(bullet, bulletReturnDelay));
    }

    protected virtual void StartCooldown()
    {
        isCooldown = true;
        StartCoroutine(ShootCooldown(fireRate));
    }

    protected virtual bool CheckShootRestrictions()
    {
        if (isCooldown) return false;

        if (bulletPool.Count == 0) return false;

        return true;
    }

    IEnumerator ShootCooldown(float cooldown)
    {
        yield return new WaitForSeconds(cooldown);

        isCooldown = false;
    }

    IEnumerator ReturnBulletToPool(Bullet bullet, float delay)
    {
        yield return new WaitForSeconds(delay);

        bullet.gameObject.SetActive(false);
        bulletPool.Enqueue(bullet);
    }
}
