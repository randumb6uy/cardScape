using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class dragNdrop : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler
{
    bool isDragging;
    bool hasExitedSprite;
    bool hasEnteredSrite;
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
    }

    
}
