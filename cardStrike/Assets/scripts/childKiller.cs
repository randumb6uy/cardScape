using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childKiller : MonoBehaviour
{
   
    GameObject hand;
    public float delay;
    Manager mg;
    public battleSystem system;
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
                    if (system.playerUnit.energy >= child.GetComponent<cardFunc>().energy)
                    {
                        Destroy(child,delay);
                    }else
                    {
                        
                    }
                    Debug.Log("casted");
                    child.GetComponent<cardFunc>().func();
                    Debug.Log(system.enemyUnit.health);
                    Debug.Log(system.playerUnit.energy);
                    if (hand.transform.childCount == 0)
                    {
                        mg.deal();   
                    }    
            }   
        }    
    
    }
    
}    