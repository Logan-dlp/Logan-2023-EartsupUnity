using UnityEngine;

[System.Serializable]
public struct Stats
{
    [Range(0, 100)] public int healthValue;
    [Range(0, 50)] public int manaValue;
}