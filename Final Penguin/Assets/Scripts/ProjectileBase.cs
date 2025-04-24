using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    public float speed = 0.5f; 
    //public GameObject thisObject; 
    public float timer = 0f; 
    public float lifeTime = 3f;
   
    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifeTime)
        { 
            Destroy(gameObject);
        } 
    }
}
