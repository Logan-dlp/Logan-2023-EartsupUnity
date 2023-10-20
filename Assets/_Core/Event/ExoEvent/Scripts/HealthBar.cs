using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
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

    private void HealthChanged(float newHealth)
    {
        _image.fillAmount = newHealth * .01f;
    }
}
