using UnityEngine;
using UnityEngine.Events;

public class ToggleInputListener : MonoBehaviour
{
    [SerializeField] private InputEventButton _inputEventButton;
    [SerializeField] private UnityEvent _callbacks;

    private void OnEnable()
    {
        _inputEventButton.InputEvent += InvokeEvent;
    }

    private void OnDisable()
    {
        _inputEventButton.InputEvent -= InvokeEvent;
    }

    public void InvokeEvent()
    {
        _callbacks?.Invoke();
    }
}
