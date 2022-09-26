using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closer : MonoBehaviour
{
    public GameObject Object;
    public Transform unActiveWindows;
    public void Close(){
        Object.transform.position = unActiveWindows.position;
        Object.transform.SetParent(unActiveWindows);
    }
}
