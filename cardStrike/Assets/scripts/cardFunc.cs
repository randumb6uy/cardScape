using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardFunc : MonoBehaviour
{
    // Start is called before the first frame update
    //public Image artwork;
    public int energy;
    public string _name;
    battleSystem System;
    public cardTypes type;
    public int dmg;
    public int defence;
    public int heal;
    public cardAcces acces;
    private void Start() 
    {
    System = GameObject.FindWithTag("handler").GetComponent<battleSystem>();
    }
    public void func()
    {
        
        
        if (type == cardTypes.attack)
        {
            System.playerUnit.energy -= energy;
            Debug.Log(dmg);
            if (System.enemyUnit.health < dmg)
            {
                System.enemyUnit.health = 0;  
            }
            else
            {
                System.enemyUnit.health -= dmg;
                System.enemyHud.SetHP(System.enemyUnit.health); 
                System.SetNrg(System.playerUnit.energy);
            }    
        }      
        else if (type == cardTypes.defence)
        {
            Debug.Log(defence); 
        } 
        else if (type == cardTypes.heal)
        {
            Debug.Log(heal);   
        }   
        
    }
    
}
