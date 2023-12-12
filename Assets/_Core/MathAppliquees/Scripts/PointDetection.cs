using System;
using UnityEditor;
using UnityEngine;

public class PointDetection : MonoBehaviour
{
    [SerializeField] private Transform _pointTransform;
    [SerializeField, Range(0, 10)] private float _radiusDetection;
    
    private void OnDrawGizmos()
    {
        Vector3 distance = _pointTransform.position - transform.position;
        
        if (distance.sqrMagnitude < _radiusDetection * _radiusDetection)
        {
            Handles.color = Color.green;
        }
        else
        {
            Handles.color = Color.white;
        }
        
        Handles.DrawWireDisc(transform.position, transform.forward, _radiusDetection);
    }
}
