using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSnowPlayer : ProjectileBase
{

   public Rigidbody2D rb; 
   public CharacterMovement player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharacterMovement>();

        rb = GetComponent<Rigidbody2D>();
        
        if (player.isShootingRight == true)
        {
            rb.AddForce(transform.right * speed, ForceMode2D.Impulse);
        }
        else if (player.isShootingRight == false)
        {
           rb.AddForce(-transform.right * speed, ForceMode2D.Impulse); 
        }
        rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}