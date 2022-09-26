using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode]
public class DinamicTooltipSizing : MonoBehaviour
{
    private LayoutElement layoutElement;
    
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        layoutElement = GetComponent<LayoutElement>();
        //textLine = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    
    void Update()
    {
        //var isMissing = ReferenceEquals(textLine, null) ? false : (textLine ? false : true);
        //if (!isMissing)
        //{
        //    transform.GetChild(0).GetComponent<TMP_Text>();
        //}
        //if (textLine != null)
        if (text.Length < 30){
            layoutElement.enabled = false;
        }    
        else {
            layoutElement.enabled = true;
        }
    }
}
