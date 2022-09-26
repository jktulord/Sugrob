using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogGraph  
{
    public Dictionary<string, Entry> Entries;
    public DialogGraph(Dictionary<string, Entry> _Entries){
        Entries = _Entries;
    }
}