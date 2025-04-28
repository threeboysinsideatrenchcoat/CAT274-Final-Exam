using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
       public static GameManager Instance;

       public int health = 3;

       public Image heart1;
       public Image heart2;
       public Image heart3;
       public Image bHeart3;
       public Image bHeart2;
       public Image bHeart1;

       public GameObject hearts;



    void Awake()
 {
    if(Instance  == null)
    {
        DontDestroyOnLoad(gameObject);
        Instance = this;
    }
    else
    {
        Destroy(gameObject);
    }
 }
    void Start()
    {
        bHeart3.enabled = false;
        bHeart2.enabled = false;
        bHeart1.enabled = false;
        hearts.GetComponent<Canvas>().enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        // to set health on the beginning of a scene
        if (health <= 0)
        {
            SceneManager.LoadScene("Title");
        }
        if ((SceneManager.GetActiveScene().buildIndex) == 0)
        {
            health = 3;
        }

        if ((SceneManager.GetActiveScene().buildIndex) == 1)
        {
           hearts.GetComponent<Canvas>().enabled = true;
        }
        else{hearts.GetComponent<Canvas>().enabled = false;}
       
        if (health == 3)
        {
            heart3.enabled = true;
            heart2.enabled = true;
            heart1.enabled = true;
            bHeart3.enabled = false;
            bHeart2.enabled = false;
            bHeart1.enabled = false;
        }
        if(health == 2)
        {
            heart3.enabled = false;
            heart2.enabled = true;
            heart1.enabled = true;
            bHeart3.enabled = true;
            bHeart2.enabled = false;
            bHeart1.enabled = false;
        }
        if(health == 1)
        {
            heart3.enabled = false;
            heart2.enabled = false;
            heart1.enabled = true;
            bHeart3.enabled = true;
            bHeart2.enabled = true; 
            bHeart1.enabled = false; 
        }
    }
}


