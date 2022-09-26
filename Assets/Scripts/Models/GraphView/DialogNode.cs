using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogNode
{
    public Dictionary<string, Entry> Entries;
    public DialogNode(Dictionary<string, Entry> _Entries){
        Entries = _Entries;
    }
}