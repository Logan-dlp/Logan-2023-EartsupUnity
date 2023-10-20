using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Collider))]
public class CharacterBehaviour : MonoBehaviour
{
    private int _healthInt = 100;
    
    [SerializeField] private ScriptableEventInt _scriptableEventInt;

    private void Start()
    {
        _scriptableEventInt.Event?.Invoke(_healthInt);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            LoseHealth();
        }
    }

    public void LoseHealth()
    {
        if (_healthInt > 0)
        {
            _healthInt -= 10;
            _scriptableEventInt.Event?.Invoke(_healthInt);
        }
    }
}
