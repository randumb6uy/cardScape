using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class pointer : MonoBehaviour ,IDropHandler
{
  
  
  
   public void  OnDrop(PointerEventData eventData)
   {
     
      Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
      
      if(d != null)
      {
        d.originalParent = this.transform; 
      }
   } 
}
