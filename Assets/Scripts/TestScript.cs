using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class TestScript : MonoBehaviour {

    [Header("Player Movement")]
    [SerializeField] private float Speed = 1f;
    [Space(10f)] public float JumpHeight;
    [HideInInspector] public int CreatorIndex;
}

#if UNITY_EDITOR
[UnityEditor.CustomEditor(typeof(TestScript))]
public class TestScriptInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUILayout.Label("I don't even Know");
    }
}
#endif