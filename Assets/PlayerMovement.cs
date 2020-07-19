using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player
{
    public float xmin, xmax, ymin, ymax;
}
public class PlayerMovement : MonoBehaviour
{
    public Player player;
    Rigidbody2D rb;//player rigidbody

    public float speed;
   

    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ObjectPooler.instance.SpawnFromPool("laserBullet", rb.transform.position, Quaternion.identity);
        }
       
    }
    void FixedUpdate()
    {
        float horizonatalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizonatalMove, verticalMove)*speed;
        rb.position = new Vector2(Mathf.Clamp(rb.position.x, player.xmin, player.xmax), Mathf.Clamp(rb.position.y, player.ymin, player.ymax));
    }
}
