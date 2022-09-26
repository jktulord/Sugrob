using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorySystem : MonoBehaviour
{
    public MessageWindow HQMessageWindow;
    public MessageWindow AlexMessageWindow;
    public MessageWindow BeckyMessageWindow;
    public MessageWindow BorisMessageWindow;
    public MessageWindow GenadiMessageWindow;
    public MessageWindow SebastianMessageWindow;
    void Start()
    {
        HQMessageWindow.ClearAll();
        Dialog HQDay1Dialog = HQDay1.Get();

        HQMessageWindow.dialog = HQDay1Dialog;
        HQMessageWindow.NextDialogStep("HQ_Day1_1");
        
        Dialog AlexDay1Dialog = AlexDay1.Get1();
        Dialog BeckyDay1Dialog = BeckyDay1.Get1();
        Dialog BorisDay1Dialog = BorisDay1.Get1();
        Dialog GenaDay1Dialog = GenaDay1.Get1();
        Dialog SebasDay1Dialog = SebasDay1.Get1();

        AlexMessageWindow.ClearAll();
        AlexMessageWindow.dialog = AlexDay1Dialog;
        AlexMessageWindow.NextDialogStep("Alex_Day1_1");
        
        BeckyMessageWindow.ClearAll();
        BeckyMessageWindow.dialog = BeckyDay1Dialog;
        BeckyMessageWindow.NextDialogStep("Becky_Day1_1");
        BeckyMessageWindow.gameObject.SetActive(false);

        BorisMessageWindow.ClearAll();
        BorisMessageWindow.dialog = BorisDay1Dialog;
        BorisMessageWindow.NextDialogStep("Boris_Day1_intro");
        BorisMessageWindow.gameObject.SetActive(false);
        
        GenadiMessageWindow.ClearAll();
        GenadiMessageWindow.dialog = GenaDay1Dialog;
        GenadiMessageWindow.NextDialogStep("Gena_Day1_intro");
        GenadiMessageWindow.gameObject.SetActive(false);

        SebastianMessageWindow.ClearAll();
        SebastianMessageWindow.dialog = SebasDay1Dialog;
        SebastianMessageWindow.NextDialogStep("Sebas_Day1_intro");
        SebastianMessageWindow.gameObject.SetActive(false);
        //HQMessageWindow.LeftMessage("1223");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
