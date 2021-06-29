using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject card;
    public GameObject[] cards;
    public Transform parent;
    private void Start() 
    {
        for (int i = 0; i < 6; i++)
        {
            deal();
        }    
    }
    public void deal()
    {
        int rand = Random.Range(0 , cards.Length);
        card = Instantiate(cards[rand] , transform.position , Quaternion.identity) as GameObject;
        card.transform.SetParent(parent);
    }    
    
        

   
}
