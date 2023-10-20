using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableEventInt), menuName = "ExoEvent/ScriptableEventInt")]
public class ScriptableEventInt : ScriptableObject
{
    public Action<float> Event;
}
