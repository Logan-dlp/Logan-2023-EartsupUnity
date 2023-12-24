using UnityEngine;

public enum Sign
{
    Heart,
    Diamond,
    Club,
    Spade,
}

public enum Value
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Height,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
}

[CreateAssetMenu(fileName = "new_" + nameof(CardData), menuName = "ExoSciptableObject/Card Data")]
public class CardData : ScriptableObject
{
    [SerializeField] private Value _cardValue;
    public Value CardValue { get => _cardValue; set => _cardValue = value; }
    [SerializeField] private Sign _cardSign;
    public Sign CardSign { get => _cardSign; set => _cardSign = value; }
}
