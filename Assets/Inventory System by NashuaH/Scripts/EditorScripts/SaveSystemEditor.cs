using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SaveSystem))]
[CanEditMultipleObjects]

public class SaveSystemEditor : Editor
{
    SerializedProperty itemLibrary;
    void OnEnable()
    {
        itemLibrary = serializedObject.FindProperty("itemLibrary");
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Put all the items that exist in this List");
        EditorGUILayout.LabelField("The items ID must correspond with the place on the List");
        EditorGUILayout.LabelField("Example: Big Axe ID is 0 so it must be placed in element 0");
     
         
        serializedObject.Update();
        EditorGUILayout.PropertyField(itemLibrary);
        serializedObject.ApplyModifiedProperties();
    }
}
