using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dealCards : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] slots;
    public bool[] isFull;
    public GameObject[] cards;
    GameObject Acard;
    public Transform parent; 
    List<GameObject> hand = new List<GameObject>();
    
    public void OnClick()
    {
        
        for (int i = 0; i < slots.Length ; i++)
        {
            if (isFull[i] == false)
            {
                //generates a random no for random card selection
                int rand = Random.Range(0 , cards.Length);
                //instantiantes the prefab as gameobject with random card from array
                Acard = Instantiate(cards[rand] , slots[i].transform.position ,  Quaternion.identity) as GameObject;   
                //parents it to canvas
                Acard.transform.SetParent(parent);
                //tells that this slot is occupied
                isFull[i] = true;
                //adds it to hand
                hand.Add(Acard);
            }   
        }    
    }


   
}
