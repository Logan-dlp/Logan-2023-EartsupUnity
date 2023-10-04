using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScriptableObjectInstanciate : MonoBehaviour
{
    [SerializeField]
    private ScriptableObject _scriptableObjectToInstanciate;
    private ScriptableObject ScriptableObjectToInstanciate => _scriptableObjectToInstanciate;

    private void Start()
    {
        if (_scriptableObjectToInstanciate is Weapon scriptableWeapon)
        {
            scriptableWeapon.Attack();
            Debug.Log("variable is Weapon !!");
        }

        _scriptableObjectToInstanciate = Instantiate(_scriptableObjectToInstanciate);
    }
}
