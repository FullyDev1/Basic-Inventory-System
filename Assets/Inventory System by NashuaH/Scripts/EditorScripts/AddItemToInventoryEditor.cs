using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AddItemToInventory)), CanEditMultipleObjects]


public class AddItemToInventoryEditor : Editor
{
    SerializedProperty speBool, rndBool, itemSpecific, quantitySpecific, itemsRandom;
    void OnEnable()
    {
        speBool = serializedObject.FindProperty("specificItemGive");
        rndBool = serializedObject.FindProperty("randomItemGive");
        itemsRandom = serializedObject.FindProperty("itemsToGive");
        itemSpecific = serializedObject.FindProperty("specificItem");
        quantitySpecific = serializedObject.FindProperty("specificQuant");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.LabelField("Choose if you wanna add a specific item or a random item");
       
        EditorGUILayout.PropertyField(speBool);
     
        EditorGUILayout.PropertyField(rndBool);
   
        if (speBool.boolValue && rndBool.boolValue == false)
        {
           
            EditorGUILayout.PropertyField(itemSpecific);
            
            EditorGUILayout.PropertyField(quantitySpecific);
           
        }
        else 
        if (speBool.boolValue == false && rndBool.boolValue)
        {
         
            EditorGUILayout.PropertyField(itemsRandom);
           
        }
      
        serializedObject.ApplyModifiedProperties();
    }
}
