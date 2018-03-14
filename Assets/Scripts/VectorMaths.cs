using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMaths : MonoBehaviour {
    public bool UsingTransform;
    public Vector3 PointA_Vec, PointB_Vec;
    public Transform PointA_Trans, PointB_Trans;

    private Vector3 calcualtedVector, startPoint;

    public Vector3 CalculatedVec { get { return calcualtedVector; } }

    private void Update()
    {
        CalculateVector();
    }

    public Vector3 CalculateVector()
    {
        if (UsingTransform)
        {
            if (PointA_Trans != null && PointB_Trans != null)
            {
                calcualtedVector = PointB_Trans.position - PointA_Trans.position;
                startPoint = PointA_Trans.position;
            }
        }
        else
        {
            calcualtedVector = PointB_Vec - PointA_Vec;
            startPoint = PointA_Vec;
        }
        return calcualtedVector;
    }

    [ExecuteInEditMode]
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(startPoint, startPoint + calcualtedVector);
    }
}
