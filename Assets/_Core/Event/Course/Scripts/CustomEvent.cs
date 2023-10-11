using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomEvent : MonoBehaviour
{
    private Action<int> _customAction;

    private Func<string, float, int> _customFunc;

    private void Start()
    {
        _customAction += SignalCallBack;
        _customFunc += FuncCallBack;

        StartCoroutine(WaitForSignalCoroutine());
        
        IEnumerator WaitForSignalCoroutine()
        {
            yield return new WaitForSeconds(2);

            _customAction(1);

            yield return new WaitForSeconds(1);

            int functionValue = _customFunc("Michel", .1f);
        }
    }

    private void SignalCallBack(int occurence)
    {
        Debug.Log("Signal received");
    }

    private int FuncCallBack(string name, float value)
    {
        Debug.Log("Func received");
        return 0;
    }
}
