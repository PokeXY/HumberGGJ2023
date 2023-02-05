using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Fire Rate + Aiming + Shooting
// Credit to At Least Vision, Jul 21, 2021.
// https://stackoverflow.com/questions/68353364/how-to-make-an-enemy-shoot-the-player-in-unity-2d

public class BossShoot : MonoBehaviour
{
    // Some Attribute
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
    public float projectileForce;
    public Transform firePoint;
    public GameObject enemyProjectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextFire)
        {
            if(!enemyProjectilePrefab)
                return;
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(enemyProjectilePrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = clone.GetComponent<Rigidbody2D>();
            rb.AddRelativeForce(Vector2.right * projectileForce, ForceMode2D.Impulse);
        }
    }
}
