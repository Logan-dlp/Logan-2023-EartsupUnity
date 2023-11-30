using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableInputSystem), menuName = "Inputs/Scriptable Input system")]
public class ScriptableInputSystem : ScriptableObject
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