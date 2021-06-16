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
    void Start()
    {
        
        for (int i = 0; i < slots.Length ; i++)
        {
            if (isFull[i] == false)
            {
               int rand = Random.Range(0 , cards.Length);
                Acard = Instantiate(cards[rand] , slots[i].transform.position ,  Quaternion.identity) as GameObject;   
                Acard.transform.SetParent(parent);
                isFull[i] = true;
                hand.Add(Acard);
            }   
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
