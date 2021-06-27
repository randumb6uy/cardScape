using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public GameObject[] cards;
    GameObject Acard;
    public Transform parent; 
    //GameObject hand;
    childKiller killer;
    
    
    
        List<GameObject> fireCards = new List<GameObject>();
    public enum currentTurn
    {
        player,
        enemy
    }
    public currentTurn turn;
     
     private void Awake() 
     {
        //hand = GameObject.FindWithTag("hand");
     }
      private void Start() 
    {
        while (parent.childCount <= 3)
        {
            deal();
        }   
        
    }
    private void Update() 
    {
        if (parent.childCount < 4)
        {
            deal();
        }
       
    }
    public void deal()
    {
        int rand = Random.Range(0 , cards.Length);
        //instantiantes the prefab as gameobject with random card from array
            
        Acard = Instantiate(cards[rand] , transform.position ,  Quaternion.identity) as GameObject;   
        //parents it to canvas
        Acard.transform.SetParent(parent);
    }   
            
        
    
        

   
}
