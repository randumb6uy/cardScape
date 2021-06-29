using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childKiller : MonoBehaviour
{
   
    GameObject hand;
    public float delay;
    Manager mg;
    private void Awake()
    
    {
    mg = GameObject.FindWithTag("manager").GetComponent<Manager>();
    hand = GameObject.FindWithTag("hand");  
    }
    void Update()
    {
        if (transform.childCount > 0)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                GameObject child = this.transform.GetChild(i).gameObject;
               
                Destroy(child,delay);
                Debug.Log("card casted");
                if (hand.transform.childCount <6)
                {
                    mg.deal();
                }
               
            }   
        }    
    
    }
    
}    