using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragableUI : MonoBehaviour, IDragHandler
{
    [SerializeField] private RectTransform dragRectTransform;
    public void OnDrag(PointerEventData eventData){
        dragRectTransform.anchoredPosition += eventData.delta;
        //Debug.Log("Drag");
    }

}
