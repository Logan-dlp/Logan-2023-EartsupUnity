using System;
using UnityEditor;
using UnityEngine;

public class SphereDetection : MonoBehaviour
{
    [SerializeField] private SphereDetection _otherSphereDetection;
    [SerializeField, Range(0, 10)] private float _radiusDetection;
    public float RadiusDetection => _radiusDetection;
    
    private void OnDrawGizmos()
    {
        Vector3 distance = _otherSphereDetection.transform.position - transform.position;
        float radiusSumPow = RadiusDetection + _otherSphereDetection.RadiusDetection;

        if (distance.sqrMagnitude < radiusSumPow * radiusSumPow)
        {
            Handles.color = Color.green;
        }
        else
        {
            Handles.color = Color.white;
        }
        Handles.DrawWireDisc(transform.position, transform.forward, RadiusDetection);
    }
}
