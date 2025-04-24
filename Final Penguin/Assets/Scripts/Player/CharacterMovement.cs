using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour

{
    public float speed = 0.2f;
    public float jumpForce = 10f;
    public GameObject player;
    public Rigidbody2D rb;
    public GameManager myManager;


    public GameObject snowball;

    public bool isShootingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myManager = FindObjectOfType<GameManager>();


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
            isShootingRight = false;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * speed;
            Debug.Log("D Pressed");
            isShootingRight = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(snowball, transform.position, Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collison)
    {      
        
        if (myManager.health <= 0)
        {
            Destroy(player);
            SceneManager.LoadScene("Title");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Gift" && Input.GetKey(KeyCode.Space))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Fish" && myManager.health < 3)
        {
            Destroy(collision.gameObject); 
            myManager.health += 1; 
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.gameObject.tag == "EnemySnowball")
        {
            myManager.health -= 1; 
            
        }
        if (other.gameObject.tag == "DeathBlock")
        {
            myManager.health -= 1;
            player.transform.position = new Vector3(-13.96f, -2.2f, 0f);
            
        }
    }
}
