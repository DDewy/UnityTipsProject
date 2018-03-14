using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[UnityEditor.CustomEditor(typeof(CustomEditor))]
public class CustomEditorInspector : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Log Player's Health"))
        {
            //Casting Reference of this script to our class type
            CustomEditor tempScript = (CustomEditor)target;

            tempScript.LogPlayerHealth();
        }
    }
}
