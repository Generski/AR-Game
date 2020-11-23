using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bulletPrefab;

    private bool canShoot = true;

    private void FixedUpdate()
    {
        if (canShoot == true)
        {
            StartCoroutine(Shoot());
        }

    }

    IEnumerator Shoot()
    {
        canShoot = false;

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        yield return new WaitForSeconds(2f);

        canShoot = true;
    }
}
