using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireChargeMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _timeToDestroy;

    private void Update()
    {
        transform.position += transform.up * Time.deltaTime * _speed;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
