using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;

public class DSMultipleChoiceNode : DSNode
{
    public override void Initialize(Vector2 position)
    {
        base.Initialize(position);

        DialogueType = DSDialogueType.MultipleChoice;
    
        choices.Add("Next Choice");
    }

    public override void Draw()
    {
        base.Draw();

        Button addChoiceButton = new Button()
        {
            text = "Add Choice"
        };

        mainContainer.Insert(1, addChoiceButton);

        foreach(string choice in choices) 
        {
            Port choicePort = InstantiatePort(Orientation.Horizontal,Direction.Output, Port.Capacity.Single, typeof(bool));

            choicePort.portName = "";

            Button deleteChoiceButton = new Button()
            {
                text = "X"
            };

            TextField choiceTextField = new TextField(){
                value = choice
            };

            choicePort.Add(choiceTextField);
            choicePort.Add(deleteChoiceButton);

            outputContainer.Add(choicePort);
        }

        RefreshExpandedState();
    }
}