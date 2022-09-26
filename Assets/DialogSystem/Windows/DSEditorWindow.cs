using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class DSEditorWindow : EditorWindow
{
    [MenuItem("Window/DS/DialogueGraph")]
    public static void ShowExample()
    {
        GetWindow<DSEditorWindow>("DialogGraph");
    }

    private void OnEnable() {
        AddGraph();       
    }

    private void AddGraph(){
        DSGraphView graphView = new DSGraphView();

        graphView.StretchToParentSize();

        rootVisualElement.Add(graphView);
    }
    
}
