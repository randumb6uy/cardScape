using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "card Template", menuName = "card")]
public class Card : ScriptableObject 
{
    public string _name;
    public string description;
    public int cost;
    public Sprite image;   
    public enum cardDmgType
    {
        player,
        enemy
    }
    
    public enum castType
    {
        attack,
        heal  
    }
    public float dmgToEnemy;
    public float dmgToUs;
    public float healToEnemy;
    public float healToUs;
    public void action(float enemyHealth , float ourHealth , float energy)
    {
       
       
    }
}
