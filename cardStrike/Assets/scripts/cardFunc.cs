using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardFunc : MonoBehaviour
{
    // Start is called before the first frame update
    //public Image artwork;
    public int energyReq;
    public card card;
    void Start()
    {
        //artwork.sprite = card.icon;
        energyReq = card.cost;
    }
    
    // Update is called once per frame
    
}
