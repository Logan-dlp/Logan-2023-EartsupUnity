using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class ColliderEventEmitter : MonoBehaviour
{
    [SerializeField] private UnityEvent _collisionEnterEvent;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            _collisionEnterEvent.Invoke();
        }
    }
}
