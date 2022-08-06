using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public bool reloaded;

    public float bulletForce = 5f;

    private void Start()
    {
        reloaded = true;
    }
    void Update()
    {
        if (Input.GetMouseButton(0) && reloaded)
        {
            reloaded = false;
            Shoot();
        }

        if (Input.GetKeyDown("r"))
            reloaded = true;
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(bullet.transform.right * 10, ForceMode2D.Impulse);
        Destroy(bullet, 5f);
    }
}
