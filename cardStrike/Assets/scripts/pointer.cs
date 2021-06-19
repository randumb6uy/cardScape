using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class pointer : MonoBehaviour ,IPointerExitHandler , IPointerEnterHandler
{
    
   public bool isInImage;
  public void OnPointerEnter(PointerEventData eventData)
  {
    isInImage = true;  
  }  
  public void  OnPointerExit(PointerEventData eventData)
  { 
    isInImage = false;
  }
    
}
