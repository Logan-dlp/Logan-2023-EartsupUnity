using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScriptableEventListener : MonoBehaviour
{
    [SerializeField] private ScriptableEvent _scriptableEvent;

    [SerializeField] private UnityEvent _callbacks;

    private void Awake()
    {
        _scriptableEvent.Event += InvokeEvent;
    }

    private void InvokeEvent()
    {
        _callbacks?.Invoke();
    }
}
