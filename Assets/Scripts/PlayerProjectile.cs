using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerProjectile : MonoBehaviour
{
    public GameObject hitEffectWall;
    public GameObject hitEffectEnemy;
    public float hitEffectTime;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            GameObject effectEnemy = Instantiate(hitEffectEnemy, transform.position, Quaternion.identity);
            Destroy(effectEnemy, hitEffectTime);
        }
        else if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene("Game Over");
        }
        else if (collision.gameObject.tag == "Walls")
        {
            Destroy(gameObject);
            GameObject effectWall = Instantiate(hitEffectWall, transform.position, Quaternion.identity);
            Destroy(effectWall, hitEffectTime);
        }



        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
