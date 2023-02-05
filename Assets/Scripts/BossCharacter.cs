using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossCharacter : MonoBehaviour
{
    public float bossHealth;
    public float speed;
    //private float fireRate;
    //public float projectileForce = 20f;

    [SerializeField] Transform player;

    private float distance;

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerProjectile")
        {
            bossHealth = bossHealth - 1;
            if (bossHealth == 0)
            {
                Destroy(gameObject);
            }
            //SceneManager.LoadScene("Game Over");
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            //SceneManager.LoadScene("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Get the distance of our player from our enemy

        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        // NORMALIIIIIZE
        direction.Normalize();
        // Convert from Radian to degree
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (distance < 15)
        {
            // Rotate our enemy toward the player!
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
            //Shoot();
        }

        //if (distance < 3)
        //{

        //    agent.SetDestination(player.position);

        //}
    }

    //void Shoot()
    //{
    //    fireRate = fireRate - 10f * Time.deltaTime;
    //    if (fireRate <= 0)
    //    {
    //        GameObject projectile = Instantiate(enemyProjectilePrefab, firePoint.position, firePoint.rotation);
    //        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
    //        rb.AddRelativeForce((firePoint.up * projectileForce), ForceMode2D.Impulse);
    //        fireRate = 3.3f;
    //    }
    //}

}
