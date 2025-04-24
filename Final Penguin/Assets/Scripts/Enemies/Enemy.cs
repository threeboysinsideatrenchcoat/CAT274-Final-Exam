using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
}
