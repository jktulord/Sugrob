using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;



[Serializable, Inspectable]
public class Dialog 
{
    [Inspectable]
    public Dictionary<string, Entry> Entries;
    
    public Dialog(Dictionary<string, Entry> _Entries){
        Entries = _Entries;
    }
    
}

public enum EntryType {
    Tulip, Chain, End  
}

[Serializable, Inspectable]
public class Entry
{
    
    public string id;
    public string text;
    public EntryType entry;
    public List<Answer> answers;
    public Trigger[] triggers; 
    
    public string default_transition_id;

    public Entry(string _id, string _text, EntryType _entry, List<Answer> _answers = null, Trigger[] _triggers = null, string _id_transition = null){
        id = _id;
        text = _text;
        entry = _entry;
        answers = _answers;
        triggers = _triggers;
        default_transition_id = _id_transition;
    }
    /*
    public Entry(){

    }
    */
}

public class Answer {
    public string text;
    public string transition_id;
    public Condition[] conditions;
    public Trigger[] triggers;
    public Answer(string _text, string _transition_id, Condition[] _conditions = null, Trigger[] _triggers = null){
        text = _text;
        transition_id = _transition_id;
        conditions = _conditions;
        triggers = _triggers;
    }
}

public enum ConditionType {
    IfTrue, IfFalse, 
    IfInt0, IfIntLessThan0, IfIntMoreThan0
}

public class Condition{
    public ConditionType conditionType;
    public string id;
    public Condition(string _id, ConditionType _conditionType){
        id = _id;
        conditionType = _conditionType;
    }
}

public enum TriggerType {
    SetToTrue, SetToFalse,
    Add1ToInt, Sub1ToInt 
}

public class Trigger{
    public TriggerType triggerType;
    public string id;
    public Trigger(string _id, TriggerType _triggerType){
        id = _id;
        triggerType = _triggerType;
    }
}