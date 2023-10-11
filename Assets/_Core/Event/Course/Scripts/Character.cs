using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Action<int> HealthChanged;
    
    private int _health = 100;

    [SerializeField] private ScriptableEvents onEnableEvents;

    private int Health
    {
        get => _health;
        set
        {
            _health = value;
            HealthChanged?.Invoke(_health);
        }
    }

    private void Start()
    {
        StartCoroutine(LoseHealthFromTime());

        IEnumerator LoseHealthFromTime()
        {
            while (_health > 0)
            {
                yield return new WaitForSeconds(1);
                
                _health -= 10;
            }
        }
    }

    private void OnEnable()
    {
        onEnableEvents.Event.Invoke();
    }
}
