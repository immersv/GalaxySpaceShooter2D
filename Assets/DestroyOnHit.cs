using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
    public float enemySpeed;
    private void Start()
    {
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(0, -1) *enemySpeed* Time.deltaTime;
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boundary")
        {
            return;
        }
        else if (collision.tag == "Player")
        {
            FindObjectOfType<SoundManager>().Play("playerDeath");
            Destroy(collision.gameObject);
            
        }
        else if (collision.tag == "laserBullet")
        {
            FindObjectOfType<SoundManager>().Play("laserBulletHit");
            gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
        }
    }

}
