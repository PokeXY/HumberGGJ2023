using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Distance and Player Tracking code courtesy of MoreBBlakeyyy
/// https://www.youtube.com/watch?v=2SXa10ILJms
/// January 16th, 2022
/// Indefinite attacking loop courtesy of Tanner Olsen
/// </summary>

public class EnemyCharacter : MonoBehaviour
{
    public GameObject player;
    public float speed;

    public bool isAttacking;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the distance of our player from our enemy
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        // NORMALIIIIIZE
        direction.Normalize();
        // Convert from Radian to degree
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


        if (distance < 7)
        {
            // Rotate our enemy toward the player!
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        if (distance < 5)
        {
            isAttacking = true;
        }

        if (isAttacking == true)
        {
            // Move toward the target player Game Object
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position,
            speed * Time.deltaTime);
        }
    }
}
