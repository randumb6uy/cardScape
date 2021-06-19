using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class dragNdrop : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler
{
    bool isDragging;
    pointer mouse;
    
    private void Awake() 
    {
     mouse = GameObject.FindGameObjectWithTag("hand").GetComponent<pointer>();   
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        isDragging = true;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        isDragging = false;
        
        if (mouse.isInImage == true)
        {
            
        }
    }
    
    
}
