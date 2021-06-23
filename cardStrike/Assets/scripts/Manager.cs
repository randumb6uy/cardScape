using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public GameObject[] cards;
    GameObject Acard;
    public Transform parent; 
    GameObject hand;
    childKiller killer;
    public bool full;
    public float enemyHealth;
    public float ourHealth;
    public int energy; 
    List<GameObject> fireCards = new List<GameObject>();
    public bool isPlayed;
    private void Awake() 
    {
    hand = GameObject.FindWithTag("hand");  
    }
    public void click() 
    {
        int rand = Random.Range(0 , cards.Length);
        //instantiantes the prefab as gameobject with random card from array
        Acard = Instantiate(cards[rand] , transform.position ,  Quaternion.identity) as GameObject;   
        //parents it to canvas
        Acard.transform.SetParent(parent);
    }
    
        
        
            
        
    
        

   
}
