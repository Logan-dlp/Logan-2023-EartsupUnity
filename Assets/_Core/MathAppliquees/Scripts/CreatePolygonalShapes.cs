using System;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;
using Color = UnityEngine.Color;

public class CreatePolygonalShapes : MonoBehaviour
{
    [SerializeField] private int _polygonalPointNumber;

    private void OnDrawGizmos()
    {
        
        for (int i = 0; i < _polygonalPointNumber; i++)
        {
            float tau = 2 * Mathf.PI;
            float angle = tau / _polygonalPointNumber;
            angle *= i + 1;
            
            float x = 1 * Mathf.Cos(angle);
            float y = 1 * Mathf.Sin(angle);
            Vector2 newPoint = new Vector2(x, y);
            Handles.color = Color.green;
            Handles.DrawLine(transform.position, (Vector3)newPoint);
        }
        Handles.color = Color.blue;
        Handles.DrawWireDisc(transform.position, transform.forward, 1);
    }
}
