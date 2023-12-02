using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(InputEventAxisVector2), menuName = "ExoInputSystem/Scriptable Input Vector2")]
public class InputEventAxisVector2 : ScriptableObject
{
    public Action<Vector2> InputEvent;

    public void InvokeEvent(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            InputEvent?.Invoke(ctx.ReadValue<Vector2>());
        }else if (ctx.canceled)
        {
            InputEvent?.Invoke(Vector2.zero);
        }
    }
}
