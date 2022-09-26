using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using System;
using UnityEngine.UIElements;

public enum DSDialogueType {
    SingleChoice,
    MultipleChoice
}

public class DSNode : Node
{
    
    public string dialogueName;
    public List<string> choices;
    public string text;
    public DSDialogueType DialogueType;

    public virtual void Initialize(Vector2 position)
    {
        dialogueName = "dialogueName";
        choices = new List<string>();
        text = "Dialogue text.";

        SetPosition(new Rect(position, Vector2.zero));
    }

    public virtual void Draw(){
        /* TITLE CONTAINER*/
        TextField dialogueNameTextField = new TextField(){
            value = dialogueName
        };
        titleContainer.Insert(0, dialogueNameTextField);

        /* INPUT CONTAINER*/
        Port inputPort = InstantiatePort(Orientation.Horizontal, Direction.Input, Port.Capacity.Multi, typeof(bool));

        inputPort.portName = "Dialogue Connection";

        inputContainer.Add(inputPort);

        /* EXTENSIONS CONTAINER*/

        VisualElement customDataContainer = new VisualElement();

        Foldout textFoldout = new Foldout(){
            text = "Dialogue Text"
        };

        TextField textTextField = new TextField(){
            value = text
        };

        textFoldout.Add(textTextField);

        customDataContainer.Add(textFoldout);

        extensionContainer.Add(customDataContainer);
    
    }
}
