using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;
public class HealthScript : MonoBehaviour
{
    public string characterName; 
    public int health; 
    public TextMeshProUGUI displayHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Health();
        DisplayHealth();
    }
     public void DisplayHealth()
    {
        displayHealth.text = "Health: " + health; 
    }

    public void Health()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Main");
            
        }
    }
}
