using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;

public class DSSingleChoiceNode : DSNode
{
    public override void Initialize(Vector2 position)
    {
        base.Initialize(position);

        DialogueType = DSDialogueType.SingleChoice;
    
        choices.Add("Next Dialogue");
    }

    public override void Draw()
    {
        base.Draw();

        foreach(string choice in choices) 
        {
            Port choicePort = InstantiatePort(Orientation.Horizontal,Direction.Output, Port.Capacity.Single, typeof(bool));

            choicePort.portName = choice;

            outputContainer.Add(choicePort);
        }

        RefreshExpandedState();
    }
}
