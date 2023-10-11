using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private ScriptableEventInt _scriptableEventInt;
    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Start()
    {
        _scriptableEventInt.Event += HealthChanged;
    }

    private void HealthChanged(int newHealth)
    {
        _image.fillAmount = (float)newHealth * .01f;
    }
}
