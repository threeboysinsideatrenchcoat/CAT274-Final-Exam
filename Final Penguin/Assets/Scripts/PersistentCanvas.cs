using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentCanvas : MonoBehaviour
{
    public static PersistentCanvas Instance;
    // Start is called before the first frame update
    
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
}
