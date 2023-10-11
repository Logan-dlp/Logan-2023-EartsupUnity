using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableEvents), menuName = "Events/ScriptableEvents")]
public class ScriptableEvents : ScriptableObject
{
    public Action Event;
}
