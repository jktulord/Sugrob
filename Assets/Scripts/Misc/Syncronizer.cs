using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Syncronizer : MonoBehaviour
{
    [SerializeField]
    private RectTransform targetTransform; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ((RectTransform)transform).sizeDelta = new Vector3(((RectTransform)transform).sizeDelta.x, targetTransform.sizeDelta.y, 0) ;
    }
}
