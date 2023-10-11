using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[DefaultExecutionOrder(-1)]
public class ScriptableEventsListener : MonoBehaviour
{
    [SerializeField] private ScriptableEvents scriptableEvents;

    [SerializeField] private UnityEvent _callbacks;

    private void Awake()
    {
        scriptableEvents.Event += InvokeEvent;
    }

    private void InvokeEvent()
    {
        _callbacks?.Invoke();
    }
}
