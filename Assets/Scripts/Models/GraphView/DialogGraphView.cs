using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogGraphView 
{
    public Dictionary<string, Entry> Entries;
    public DialogGraphView(Dictionary<string, Entry> _Entries){
        Entries = _Entries;
    }
}