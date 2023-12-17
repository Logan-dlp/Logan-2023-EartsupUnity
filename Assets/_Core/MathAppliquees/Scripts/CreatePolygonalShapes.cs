using System;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;
using Color = UnityEngine.Color;

public class CreatePolygonalShapes : MonoBehaviour
{
    [SerializeField, Range(2, 10)] private int _polygonalPointNumber;
    private static float _tau = 2 * Mathf.PI;

    private void OnDrawGizmos()
    {
        Handles.color = Color.green;
        Vector2[] polygonalPointArray = new Vector2[_polygonalPointNumber];
        
        for (int i = 0; i < _polygonalPointNumber; i++)
        {
            float angle = _tau / _polygonalPointNumber;
            angle *= i + 1;
            
            float x = 1 * Mathf.Cos(angle) + transform.position.x;
            float y = 1 * Mathf.Sin(angle) + transform.position.y;
            Vector2 newPoint = new Vector2(x, y);
            polygonalPointArray[i] = newPoint;
        }
        
        Handles.DrawLine(polygonalPointArray[polygonalPointArray.Length - 1], polygonalPointArray[0]);

        for (int i = 1; i < polygonalPointArray.Length; i++)
        {
            Handles.DrawLine(polygonalPointArray[i-1], polygonalPointArray[i]);
        }
    }
}
