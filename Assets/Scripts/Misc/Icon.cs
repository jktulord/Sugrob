using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Icon : MonoBehaviour, IPointerClickHandler
{
    public GameObject prefab;
    public Transform unActiveWindowSpace;
    public Transform activeWindowSpace; 
    public void OnPointerClick(PointerEventData eventData){
        prefab.transform.position = activeWindowSpace.position;
        prefab.transform.SetParent(activeWindowSpace);
    }
}
