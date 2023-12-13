using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputEventButtonListener))]
public class DisplayUserInterface : MonoBehaviour
{
    [SerializeField] private GameObject _parentMenu;
    private bool _isActive;

    private void Start()
    {
        _parentMenu.SetActive(false);
        _isActive = false;
    }

    public void ToggleMenu()
    {
        _parentMenu.SetActive(!_isActive);
        _isActive = !_isActive;
    }
}
