using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class elementFunc : MonoBehaviour
{   
    public elements item;
    Image image;
    private void Awake() 
    {
        image =  this.GetComponent<Image>();
        image.sprite = item.icon;
    }    
   
    
}
