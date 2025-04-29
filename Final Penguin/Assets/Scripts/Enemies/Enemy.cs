using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    public int health = 1; 

    public float timebetweenShots = 2f;

    public float timer = 0f; 

    public float sizeOfSnowball; 

    public GameObject snowballPrefab;
    public CharacterMovement player;
    
    public bool isPlayerRight;

    void Start()
    {
        player = FindObjectOfType<CharacterMovement>();
    }


    // Update is called once per frame
    void Update()
    {
        if ((SceneManager.GetActiveScene().buildIndex) == 0)
        {
            health = 1; 
        }

        timer += Time.deltaTime;


        if (transform.position.x < player.transform.position.x)
        {
            isPlayerRight = true;
        }

        if (transform.position.x > player.transform.position.x)
        {
            isPlayerRight = false;
        }

        if(timer >= timebetweenShots && health > 0)
        {
            if(snowballPrefab != null)
            {
                GameObject snowball = Instantiate(snowballPrefab, transform.position, Quaternion.identity);
                snowball.GetComponent<BulletSnowEnemy>().isMovingRight = isPlayerRight;

                timer = 0f; 
           }
        }
        else
        {
            return;
        }
    }

     void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.gameObject.tag == "Snowball")
        {
            health -= 1; 
            Destroy(other.gameObject);

            if(gameObject.GetComponent<SpriteRenderer>())
            {
            gameObject.GetComponent<SpriteRenderer>().color = Color.grey;
            }
         
        }
    }
}
