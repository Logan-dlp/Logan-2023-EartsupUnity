using System;
using UnityEngine;
using UnityEngine.Events;

public class InputEventAxisVector2Listener : MonoBehaviour
{
    [SerializeField] private InputEventAxisVector2 _inputEventAxisVector2;
    [SerializeField] private UnityEvent<Vector2> _callbacks;

    private void OnEnable()
    {
        _inputEventAxisVector2.InputEvent += InvokeEvent;
    }

    public void InvokeEvent(Vector2 axis)
    {
        _callbacks?.Invoke(axis);
    }
}
