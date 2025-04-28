using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SoecialEnemy : MonoBehaviour
{
    public int health = 3; 

    public float timebetweenShots = 1f;

    public float timer = 0f; 

    public float sizeOfSnowball; 

    public GameObject snowballPrefab;
    public CharacterMovement player;
    
    public bool isPlayerRight;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((SceneManager.GetActiveScene().buildIndex) == 0)
        {
            health = 3; 
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

        if(timer >= timebetweenShots && health >= 0)
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

        if(gameObject.tag == "Snowball")
        {
            health -= 1;
        }
    }
}
