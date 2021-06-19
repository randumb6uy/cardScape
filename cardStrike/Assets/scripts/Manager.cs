using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public GameObject[] cards;
    GameObject Acard;
    public Transform parent; 
    public List<GameObject> hand = new List<GameObject>();
    public GameObject area;
    public GameObject refrence;
    pointer mouse;
    dragNdrop dragChecker;
    List<GameObject> fireCards = new List<GameObject>();
    void Start()
    {
    mouse = GameObject.FindGameObjectWithTag("hand").GetComponent<pointer>();
    dragChecker = GameObject.FindGameObjectWithTag("decoy").GetComponent<dragNdrop>();
    }
    public void OnClick()
    {
        for (int i = 0; i < 6 ; i++)
        {
            int rand = Random.Range(0 , cards.Length);
            //instantiantes the prefab as gameobject with random card from array
            Acard = Instantiate(cards[rand] , transform.position ,  Quaternion.identity) as GameObject;   
            //parents it to canvas
            Acard.transform.SetParent(parent);
            hand.Add(Acard);
              
        }    
    }
        

   
}
