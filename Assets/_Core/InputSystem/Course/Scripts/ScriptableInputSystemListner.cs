using System;
using UnityEngine;
using UnityEngine.Events;

public class ScriptableInputSystemListner : MonoBehaviour
{
    [SerializeField] private ScriptableInputSystem scriptableInputSystem;
    [SerializeField] private UnityEvent _callbacks;
    
    private void OnEnable()
    {
        scriptableInputSystem.OnPerformed += InvokeEvents;
    }

    private void OnDisable()
    {
        scriptableInputSystem.OnPerformed -= InvokeEvents;
    }

    private void InvokeEvents()
    {
        _callbacks?.Invoke();
    }
}
