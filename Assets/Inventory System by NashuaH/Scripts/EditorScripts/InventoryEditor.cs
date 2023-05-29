using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
[CanEditMultipleObjects]

public class InventoryEditor : Editor
{
    SerializedProperty inventoryUI;
    void OnEnable()
    {
        inventoryUI = serializedObject.FindProperty("inventoryPanel");
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Place the parent object of the Inventory Slots here:");
        serializedObject.Update();
        EditorGUILayout.PropertyField(inventoryUI);
        serializedObject.ApplyModifiedProperties();
    }
}
