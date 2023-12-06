using System;
using UnityEditor;
using UnityEngine;

public class AnglePointDetection : MonoBehaviour
{
    [SerializeField] private Transform _pointDetection;
    [SerializeField, Range(0, 10)] private float _radiusDetection;
    [SerializeField, Range(0, 1)] private float _viewAngle;
    
    private void OnDrawGizmos()
    {
        Vector3 distance = _pointDetection.position - transform.position;
        
        if (distance.sqrMagnitude < _radiusDetection * _radiusDetection)
        {
            if (Vector3.Dot(distance.normalized, transform.right) >= _viewAngle)
            {
                Handles.color = Color.green;
            }
        }
        
        Handles.DrawWireDisc(transform.position, transform.forward, _radiusDetection);
    }
}
