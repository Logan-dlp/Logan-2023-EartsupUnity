using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(0)]
public class SignalEmitter : MonoBehaviour
{
    public Action Signal;

    private void Start()
    {
        Signal?.Invoke();
    }
}
