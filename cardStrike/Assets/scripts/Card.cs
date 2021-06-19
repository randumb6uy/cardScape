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
    public bool player;
    public bool enemy;
    public bool special;
    public bool dmg;
    public bool discard;
    public bool fireBasedDamage;
    public float dmgToEnemy;
    public float dmgToUs;
    public float healToEnemy;
    public float healToUs;
    public void action(float enemyHealth , float ourHealth , float energy)
    {
       if (special == false)
       {
            if (dmg == true)
            {
                if (player == true && enemy == false)
                {
                    ourHealth = ourHealth-dmgToUs;
                }
                else if(player == false && enemy == true)
                {
                    enemyHealth = enemyHealth - dmgToEnemy;
                }else
                {
                    enemyHealth = enemyHealth - dmgToEnemy;
                    ourHealth = ourHealth - dmgToUs;
                }
            }           
            else
            {
                if (player == true && enemy == false)
                {
                    ourHealth = ourHealth + healToUs; 
                }
                else if (player == false && enemy == true)
                {
                    enemyHealth = enemyHealth + healToEnemy;
                }else
                {
                    enemyHealth = enemyHealth + healToEnemy;
                    ourHealth = ourHealth+ healToUs;   
                }
            }
            energy = energy - cost;   
       }
       
    }
}
