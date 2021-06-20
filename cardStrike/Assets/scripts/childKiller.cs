using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childKiller : MonoBehaviour
{
    
   
    public float delay;
    // Update is called once per frame
    
    void Update()
    {
        if (transform.childCount > 0)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                GameObject child = this.transform.GetChild(i).gameObject;
                Destroy(child,delay);
            }   
        }    
    }
}
