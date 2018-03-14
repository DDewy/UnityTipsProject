using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompilerStatements : MonoBehaviour
{

    private void Start()
    {
#if UNITY_STANDALONE
        Debug.Log("Build for PC");
#endif

#if UNITY_ANDROID
        Debug.Log("Build for Android");
#endif

#if CUSTOMCOMPILER
        Debug.Log("Custom Compiler");
#endif
    }
}