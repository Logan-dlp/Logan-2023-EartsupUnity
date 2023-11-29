using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableInput), menuName = "Inputs/Scriptable Input")]
public class ScriptableInput : ScriptableObject
{
    public Action OnPerformed;

    public void Invoke(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            OnPerformed?.Invoke();
        }
    }
}