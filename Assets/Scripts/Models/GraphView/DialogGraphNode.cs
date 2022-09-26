using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;


[Serializable, Inspectable]
public class DialogGraphNode 
{
    [Inspectable]
    public Dictionary<string, Entry> Entries;
}
