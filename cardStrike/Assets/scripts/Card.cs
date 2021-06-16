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
    public void action()
    {
                
    }
}
