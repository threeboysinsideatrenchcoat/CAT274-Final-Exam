using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1; 
    public GameObject snowball;
    public CharacterMovement player;
    
    public bool isPlayerRight;
    void Start()
    {
        player = FindObjectOfType<CharacterMovement>();
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < player.transform.position.x)
        {
            isPlayerRight = true;
        }

        if (transform.position.x > player.transform.position.x)
        {
            isPlayerRight = false;
        }

        if(health >= 0)
        {
            Instantiate(snowball, transform.position, Quaternion.identity);
        }
        else
        {
            return;
        }
    }
}
