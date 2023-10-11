using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-1)]
public class SignalReciver : MonoBehaviour
{
    [SerializeField] private SignalEmitter _emitter;

    private void Start()
    {
        _emitter.Signal += TestSignal;
    }

    private void TestSignal()
    {
        Debug.Log("Signal Received from Emitter");
    }
}
