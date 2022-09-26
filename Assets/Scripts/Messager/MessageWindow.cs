using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MessageWindow : MonoBehaviour
{
    public Transform Content;
    public GameObject LeftMessagePrefab;
    public GameObject RightMessagePrefab; 
    public GameObject AnswerPrefab;
    public GameObject AnswerSpacePrefab;
    public GameObject LastAnswerSpace;
    public ViewPortControl viewPortControl;

    public Dialog dialog;
    // Start is called before the first frame update
    void Start()
    {
        
        
        //LeftMessage("Привет. Я твоя в кино водил");
        //RightMessage("Нет, не водил!");
        //CreateAnswerSpace();
        //AnswerMessage("Кто вы? Как к вам обращатьтся? Какое у вас воинское звание?", "sdsd");
        //AnswerMessage("Всё предельно ясно. К выполнению задания приступить готов!", "sdsd");
    }

    public void NextDialogStep(string id){
        Entry curEntry = dialog.Entries[id];
        //Debug.Log("Current Id "+id);
        //Debug.Log("Current EntryText "+curEntry.text);
        TriggerActivate(curEntry.triggers);
        LeftMessage(curEntry.text);
        if (curEntry.entry == EntryType.Chain){
            NextDialogStep(curEntry.default_transition_id);
        }
        else if (curEntry.entry == EntryType.End){
            //CreateAnswerSpace();
        }
        else 
        {
            CreateAnswerSpace();
            //Debug.Log("curEntry.answers.Count "+curEntry.answers.Count);
            for (int i = 0; i < curEntry.answers.Count; i++){
                int CheckedConditions = 0;
                if (curEntry.answers[i].conditions == null)
                {
                    //Debug.Log("curEntry.answers["+i+"].text "+curEntry.answers[i].text);    
                    AnswerMessage(curEntry.answers[i].text, curEntry.answers[i].transition_id, curEntry.answers[i].triggers );
                    continue;
                }
                
                
                for (int j = 0; j < curEntry.answers[i].conditions.Length; j++){
                    Condition cur_condition = curEntry.answers[i].conditions[j];
                    switch (cur_condition.conditionType)
                    {
                          
                        case ConditionType.IfInt0:
                            if (TriggerSystem.CheckInt(cur_condition.id, 0))
                                CheckedConditions++;
                            break;
                        
                        case ConditionType.IfFalse:
                            if (TriggerSystem.CheckTrigger(cur_condition.id, false))
                                CheckedConditions++;
                            break;
                        
                        case ConditionType.IfTrue:
                            if (TriggerSystem.CheckTrigger(cur_condition.id, true))
                                CheckedConditions++;
                            break;
                    }
                }

                if (CheckedConditions >= curEntry.answers[i].conditions.Length)
                {
                    AnswerMessage(curEntry.answers[i].text, curEntry.answers[i].transition_id,  curEntry.answers[i].triggers);
                }
                
            }
        }
        ScrollToBottom();
        //Content.GetComponent<VerticalLayoutGroup>().enabled = false;
        //Content.GetComponent<VerticalLayoutGroup>().enabled = true;
        //viewPortControl
    }

    public void LeftMessage(string text){
        GameObject cur = Instantiate(LeftMessagePrefab, Content);
        cur.GetComponent<MessageCloud>().SetText(text);
    }
    
    public void RightMessage(string text){
        GameObject cur = Instantiate(RightMessagePrefab, Content);
        cur.GetComponent<MessageCloud>().SetText(text);
    }

    public void AnswerMessage(string text, string id, Trigger[] triggers){
        //Destroy(LastAnswerSpace);
        //if (LastAnswerSpace == null){
            
        
        GameObject cur = Instantiate(AnswerPrefab, LastAnswerSpace.transform);
        MessageCloud messageCloud = cur.GetComponent<MessageCloud>();
        messageCloud.SetText(text);
        messageCloud.text = text;
        messageCloud.id_lead = id;
        messageCloud.triggers = triggers;
        messageCloud.answerEvent = new AnswerEvent();
        messageCloud.answerEvent.AddListener(AnswerActivate);
        //messageCloud.transform.GetChild(0).GetChild(0).GetComponent<Button>().onClick.AddListener(messageCloud.InvokePress);
        //Debug.Log(messageCloud.transform.GetChild(0).GetChild(0).name); 
    }

    public void CreateAnswerSpace(){
        GameObject anwerSpace = Instantiate(AnswerSpacePrefab, Content);
        LastAnswerSpace = anwerSpace;
        Destroy(anwerSpace.transform.GetChild(0).gameObject);
    }

    public void AnswerActivate(string text, string id_lead, Trigger[] triggers){
        ClearAnswers();
        RightMessage(text);

        TriggerActivate(triggers);
        //TriggerSystem.ChangeTrigger(id_lead, true);
        NextDialogStep(id_lead);
    }

    public void TriggerActivate(Trigger[] triggers){
        if (triggers == null)
            return;
        for (int j = 0; j < triggers.Length; j++){
            Trigger curTrigger = triggers[j];
            int oldValue = 0;
            switch (curTrigger.triggerType)
            {
                case TriggerType.SetToFalse:
                    TriggerSystem.ChangeTrigger(curTrigger.id, false);
                    break;
                case TriggerType.SetToTrue:
                    TriggerSystem.ChangeTrigger(curTrigger.id, true);
                    break;
                case TriggerType.Add1ToInt:
                    oldValue = TriggerSystem.GetInt(curTrigger.id);
                    TriggerSystem.ChangeInt(curTrigger.id, oldValue+1);
                    break;
                case TriggerType.Sub1ToInt:
                    oldValue = TriggerSystem.GetInt(curTrigger.id);
                    TriggerSystem.ChangeInt(curTrigger.id, oldValue-1);
                    break;
            }
        }
    }


    public void ClearAll(){
        for (int i = 0; i < Content.childCount; i++){
            Destroy(Content.GetChild(i).gameObject);
        }
    }
    public void ClearAnswers(){
        if (LastAnswerSpace != null)
            Destroy(LastAnswerSpace);
    }


    
    
    public IEnumerator ScrollToBottom()
    {
        yield return new WaitForSeconds(0.5f);
        viewPortControl.ScrollToBottom();
        //viewPortControl.ScrollingDown = true;
        //viewPortControl.ScrollToBottom();
    }
    private void Update() {
        
    }

}
