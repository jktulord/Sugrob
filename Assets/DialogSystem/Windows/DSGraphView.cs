using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;
using System;

public class DSGraphView : GraphView
{
    public DSGraphView(){
        AddManipulators();
        AddGridBackground();

        //CreateNode();

    }

    public override List<Port> GetCompatiblePorts(Port startPort, NodeAdapter nodeAdapter)
    {
        List<Port> compatiblePorts = new List<Port>();

        ports.ForEach(port => {
            if (startPort == port){
                return;
            }
            if ( startPort.node == port.node){
                return;
            }
            if (startPort.direction == port.direction){
                return;
            }
            compatiblePorts.Add(port);
        }
        );

        return compatiblePorts;
    }

    private void AddManipulators(){
        SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);
        this.AddManipulator(new ContentDragger());
        this.AddManipulator(new ContentDragger());
        this.AddManipulator(new SelectionDragger());
        this.AddManipulator(new RectangleSelector());
    
        this.AddManipulator(CreateNodeContextualMenu("Add Node (Single choice)", DSDialogueType.SingleChoice));
        this.AddManipulator(CreateNodeContextualMenu("Add Node (Multiple choice)", DSDialogueType.MultipleChoice));
    
        this.AddManipulator(CreateGroupContextualMenu());
    }

    private IManipulator CreateGroupContextualMenu()
    {
        ContextualMenuManipulator contextualMenuManipulator = new ContextualMenuManipulator(
            menuEvent => menuEvent.menu.AppendAction("Add Group", actionEvent => AddElement(CreateGroup("Dialog Group", actionEvent.eventInfo.localMousePosition)))
        );

        return contextualMenuManipulator;
    }

    private IManipulator CreateNodeContextualMenu(string actionTitle, DSDialogueType dialogueType)
    {
        ContextualMenuManipulator contextualMenuManipulator = new ContextualMenuManipulator(
            menuEvent => menuEvent.menu.AppendAction(actionTitle, actionEvent => AddElement(CreateNode(dialogueType, actionEvent.eventInfo.localMousePosition)))
        );

        return contextualMenuManipulator;
    }

    private GraphElement CreateGroup(string title, Vector2 localMousePosition){
        
        Group group = new Group(){
            title = title
        };

        group.SetPosition(new Rect(localMousePosition, Vector2.zero));

        return group;

    }

    private DSNode CreateNode(DSDialogueType dialogueType, Vector2 position){
        Type nodeType = Type.GetType($"DS{dialogueType}Node");
        DSNode node = (DSNode)Activator.CreateInstance(nodeType);
        node.Initialize(position);
        node.Draw();
        //AddElement(node);
        return node;
    }

    public void AddGridBackground() 
    {
        GridBackground gridBackground = new GridBackground();
        gridBackground.StretchToParentSize();
        Insert(0, gridBackground);
    }
}
