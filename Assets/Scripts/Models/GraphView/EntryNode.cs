using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;

[Serializable, Inspectable]
public class EntryNode
{
    [Inspectable]
    public string id;
    [TextArea(3, 10), Inspectable]
    public List<String> textLines;
    
    [Inspectable]
    public EntryType entry;
    [Inspectable]
    /*
    public List<Answer> answers;
    [Inspectable]
    public Trigger[] triggers;
    [Inspectable]
    */
    public string default_transition_id;
}