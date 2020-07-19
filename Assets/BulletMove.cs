using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bulletSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D bulletRigidbody = GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = new Vector2(0,1.0f) * bulletSpeed;
       
    }
    

}
