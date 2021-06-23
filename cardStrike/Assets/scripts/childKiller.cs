using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childKiller : MonoBehaviour
{
    
   
    public float delay;
    Manager mg;
    private void Awake()
    {
    mg = GameObject.FindWithTag("manager");
    }
    void Update()
    {
        if (transform.childCount > 0)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                GameObject child = this.transform.GetChild(i).gameObject;
                mg.click();
                Destroy(child,delay);
                
            }   
        }    
    }
}
