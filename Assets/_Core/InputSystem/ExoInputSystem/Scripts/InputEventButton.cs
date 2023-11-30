using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(InputEventButton), menuName = "ExoInputSystem/Scriptable Input")]
public class InputEventButton : ScriptableObject
{
    public Action InputEvent;

    public void InvokeEvent(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            InputEvent?.Invoke();
        }
    }
}
