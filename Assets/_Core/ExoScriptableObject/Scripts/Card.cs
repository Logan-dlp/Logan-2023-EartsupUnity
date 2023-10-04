using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : ScriptableObject
{
    [SerializeField] private string[] _cardSign = { "Piques", "Carreaux", "Coeurs", "Trefles" };
    public string[] CardSign => _cardSign;

    [SerializeField] private string[] _cardValue = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valet", "Dame", "Roi" };
    public string[] CardValue => _cardValue;
}
