using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private CharacterBehaviour _character;

    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Start()
    {
        //_character.HealthChanged += ChangeHealthBar;
    }

    public void OnCharacterEnable()
    {
        Debug.Log("On character enable");
    }

    private void ChangeHealthBar(int newHealthValue)
    {
        _image.fillAmount = newHealthValue * .1f;
    }
}
