using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody)), RequireComponent(typeof(Collider))]
public class CharacterBehaviour : MonoBehaviour
{
    private int _health = 100;
    
    [SerializeField] private ScriptableEventInt _scriptableEventInt;

    private void Start()
    {
        _scriptableEventInt.Event?.Invoke(_health);
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
        if (_health > 0)
        {
            _health -= 10;
            _scriptableEventInt.Event?.Invoke(_health);
        }
    }
}
