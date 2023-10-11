using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableEvent), menuName = "Events/ScriptableEvents")]
public class ScriptableEvent : ScriptableObject
{
    public Action Event;
}
