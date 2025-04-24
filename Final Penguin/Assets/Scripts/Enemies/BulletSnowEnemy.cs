using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSnowEnemy : ProjectileBase
{

   public Rigidbody2D rb; 

   public Enemy enemy;

   public bool isMovingRight = false;

    // Start is called before the first frame update
    void Start()
    {
       // enemy = FindObjectOfType<Enemy>();

        rb = GetComponent<Rigidbody2D>();

        if (isMovingRight == true)
        {        
            rb.AddForce(transform.right * speed, ForceMode2D.Impulse);
            Debug.Log("Is shooting right.");
        }
        
        if (isMovingRight == false)
        {
            rb.AddForce(-transform.right * speed, ForceMode2D.Impulse);
            Debug.Log("Is shooting left.");
        }
        
        rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}