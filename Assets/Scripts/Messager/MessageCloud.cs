using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.Events;
using UnityEngine.UI;

public class AnswerEvent : UnityEvent<string, string, Trigger[]> {}

//[ExecuteInEditMode]
public class MessageCloud : MonoBehaviour
{
    //public TMP_Text tMP_Text;
    public Transform Content;
    public GameObject Prefab;
    public string text;
    public string id_lead;
    public AnswerEvent answerEvent;
    public Trigger[] triggers;


    // Update is called once per frame
    void Update()
    {
        /*
        if (tMP_Text != null)
            tMP_Text.text = text;
        */
    }

    public void InvokePress()
    {
        answerEvent.Invoke(text, id_lead, triggers);
    }
    
    public void SetText(string[] lines){
        foreach (string line in lines){
            Instantiate(Prefab, Content); 
            GameObject textLine = Instantiate(Prefab, Content);
            textLine.GetComponent<TMP_Text>().text = line;
        }
    }
    public void SetText(string text){
        for (int i = 0; i < Content.childCount; i++)
        {
            Destroy(Content.GetChild(i).gameObject);
        }
        //Debug.Log("Seted Text"+text);
        if (text == null)
            return;
        string[] lines = text.Split('$');
       // Debug.Log(lines.Length);
        
        /*for (int i = lines.Length-1; i > -1; i--)
        {
            GameObject textLine = Instantiate(Prefab, Content);
            textLine.GetComponent<TMP_Text>().text = lines[i];
            Button button = textLine.GetComponent<Button>();
            if (button != null)
                button.onClick.AddListener(InvokePress);
        }
        */
        for (int i = 0; i < lines.Length; i++)
        {
            GameObject textLine = Instantiate(Prefab, Content);
            textLine.GetComponent<TMP_Text>().text = lines[i];
            Button button = textLine.GetComponent<Button>();
            if (button != null)
                button.onClick.AddListener(InvokePress);
        }
        if (lines.Length > 0)
        {
            Content.GetComponent<DinamicTooltipSizing>().text = text;
        }
        //foreach (string line in lines){
        //  Instantiate(Prefab, Content); 

        //}
    }

}
