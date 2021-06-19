using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class pointer : MonoBehaviour ,IDropHandler
{
  GameObject image;
  GameObject Mger;
  Manager Mg;
  
  
  private void Start() 
  {
    Mger = GameObject.FindWithTag("manager");
    image = GameObject.FindWithTag("hand");
    Mg = Mger.GetComponent<Manager>();
    
  }
   public void  OnDrop(PointerEventData eventData)
   {
     
      Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
      if(d != null)
      {
        
       
        
      }
   } 
}
