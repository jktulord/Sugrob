using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class TriggerSystem : MonoBehaviour
{
    public static Dictionary<string, bool> Triggers;
    public static Dictionary<string, int> Ints;
    void Awake(){
        Triggers = new Dictionary<string, bool>();
        Ints = new Dictionary<string, int>();
    }

    public static void ChangeTrigger(string id, bool value){
        if (Triggers.ContainsKey(id))  
            Triggers[id] = value;
        else 
        {
            Triggers.Add(id, value);
        }
    }

    public static bool CheckTrigger(string id, bool value){
        if (Triggers.ContainsKey(id))  
            return (value == Triggers[id]);
        else 
        {
            Triggers.Add(id, false);
            return (Triggers[id] == value);
        }
    }

    public static void ChangeInt(string id, int value){
        if (Ints.ContainsKey(id)){
            Debug.Log("ChangeInt("+id+","+value+") previous value:"+Ints[id]+"");  
            Ints[id] = value;
        }
        else 
        {
            Debug.Log("Int added("+id+","+value+") ");  
            Ints.Add(id, value);
        }
    }

    public static bool CheckInt(string id, int value){
        if (Ints.ContainsKey(id)){
            Debug.Log("Checkint("+id+","+value+") return:"+(value == Ints[id])+"");
            return (value == Ints[id]);
        }  
        else 
        {
            Ints.Add(id, 0);
            Debug.Log("Int added("+id+","+value+") "); 
            return (Ints[id] == value);
        }
    }

    public static int GetInt(string id){
        if (Ints.ContainsKey(id))  
            return (Ints[id]);
        else 
        {
            Ints.Add(id, 0);
            Debug.Log("Int added("+id+","+0+") "); 
            return (Ints[id]);
        }
    }

}
