using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[UnityEditor.CustomEditor(typeof(VectorMaths))]
public class VectorMathsInspector : Editor
{
    public override void OnInspectorGUI()
    {
        VectorMaths script = (VectorMaths)target;

        Vector3 calculatedVector = script.CalculatedVec, StartPoint = Vector3.zero;

        script.UsingTransform = GUILayout.Toggle(script.UsingTransform, "Use Transforms");

        if (script.UsingTransform)
        {
            script.PointA_Trans = (Transform)EditorGUILayout.ObjectField("Point A", script.PointA_Trans, typeof(Transform), true);
            script.PointB_Trans = (Transform)EditorGUILayout.ObjectField("Point B", script.PointB_Trans, typeof(Transform), true);

            if (!Application.isPlaying)
                script.CalculateVector();
        }
        else
        {
            script.PointA_Vec = EditorGUILayout.Vector3Field("Point A", script.PointA_Vec);
            script.PointB_Vec = EditorGUILayout.Vector3Field("Point B", script.PointB_Vec);
            
            if (!Application.isPlaying)
                script.CalculateVector();
        }

        GUILayout.Label("Vector is : " + calculatedVector);
        GUILayout.Label("Vector Length is: " + calculatedVector.magnitude);
    }
}
