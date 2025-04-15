using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : HealthScript

{
    public float speed = 0.2f;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position += Vector3.down * speed;
            Debug.Log("S Pressed");
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += Vector3.left * speed;
            Debug.Log("A Pressed");
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * speed;
            Debug.Log("D Pressed");
        }
    }

   // private void OnCollisionEnter2D(Collision2D collison)
   // {  
        
       // if (collison.gameObject.tag == "Enemy")//&& health = 0
       // {
         //   Destroy(player);
         //   SceneManager.LoadScene("Main");
       // }
   // }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Gift" && Input.GetKey(KeyCode.Space))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Fish")// && Health < 3)
        {
            Destroy(collision.gameObject); 
            health = health + 1; 
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.gameObject.tag == "Snowball")
        {
            health = health - 1; 
            
        }
    }
}
