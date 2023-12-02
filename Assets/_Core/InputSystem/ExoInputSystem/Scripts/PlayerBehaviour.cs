using System;
using Unity.Mathematics;
using UnityEditor.Search;
using UnityEngine;

[RequireComponent(typeof(InputEventButtonListener))]
public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float _speedMovement = 1;
    [SerializeField] private float _speedRotation = 1;
    [SerializeField] private GameObject _fireCharge;
    private Vector2 AxisMovement = Vector2.zero;

    private void Update()
    {
        transform.position += transform.up * AxisMovement.y * _speedMovement * Time.deltaTime;
        
        transform.Rotate(-transform.forward * AxisMovement.x * _speedRotation * Time.deltaTime);
    }

    public void Shoot()
    {
        Vector3 fireInstancePosition = transform.position + transform.up;
        Instantiate(_fireCharge, fireInstancePosition, transform.rotation);
    }

    public void SetAxisMouvement(Vector2 axis)
    {
        AxisMovement = axis;
        Debug.Log(axis);
    }
}
