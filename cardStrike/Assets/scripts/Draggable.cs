using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Draggable : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler
{
    
   
    public Transform originalParent = null;
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        
        originalParent = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        this.transform.SetParent(originalParent);
        
    
    }
   
      
    
    
}
