using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //AudioSource footsteps;
    public float playerHealth = 5f;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;
    public Animator animator;


    Vector2 movement;
    Vector2 mousePos;

    void Start()
    {
        //footsteps = GetComponent<AudioSource>();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyProjectile")
        {
            playerHealth = playerHealth - 1;
            if (playerHealth == 0)
            {
                SceneManager.LoadScene("GameOver");
            }

        }

        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("Speed", 1);
        }
        else if (movement.x == 0 && movement.y == 0)
        {
            animator.SetFloat("Speed", 0);
        }

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;



        //if (movement.x != 0 || movement.y != 0)
        //{
        //    footsteps.Play();
        //}
    }
}
