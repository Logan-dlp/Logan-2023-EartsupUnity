using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "new_Weapons", menuName = "Projects/Weapon")]
public class Weapon : ScriptableObject
{
    [SerializeField] private int _damageValue = 10;
    public int DamageValue { get => _damageValue; set => _damageValue = value; }

    private void Awake()
    {
        Debug.Log("Weapon::Awake");
    }

    private void OnEnable()
    {
        Debug.Log("Weapon::OnEnable");

        _damageValue += 10;
    }

    public void Attack()
    {
        return;
    }
    
    [ContextMenu("Create Asset From Scriptable Object Reference")]
    private void CreateAssetFromScriptableObjectReference()
    {
        Weapon newWeaponAsset = CreateInstance<Weapon>();
        newWeaponAsset.DamageValue = 35;
        AssetDatabase.CreateAsset(newWeaponAsset, "Assets/_Core/Scripts/Cours/Data/Whip_Weapons.asset");
    }
}
