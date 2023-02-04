using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    //AudioSource projectile;
    public Transform firePoint;
    public GameObject projectilePrefab;

    public float projectileForce = 20f;

    private void Start()
    {
        //projectile = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            //projectile.Play();
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.AddForce((firePoint.up * projectileForce), ForceMode2D.Impulse);

    }
}
