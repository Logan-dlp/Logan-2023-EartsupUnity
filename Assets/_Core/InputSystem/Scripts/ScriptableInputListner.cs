using System;
using UnityEngine;
using UnityEngine.Events;

public class ScriptableInputListner : MonoBehaviour
{
    [SerializeField] private ScriptableInput _scriptableInput;
    [SerializeField] private UnityEvent _callbacks;
    
    private void OnEnable()
    {
        _scriptableInput.OnPerformed += InvokeEvents;
    }

    private void OnDisable()
    {
        _scriptableInput.OnPerformed -= InvokeEvents;
    }

    private void InvokeEvents()
    {
        _callbacks?.Invoke();
    }
}
