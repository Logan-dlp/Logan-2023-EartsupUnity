using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CardInstanciator : MonoBehaviour
{
    [SerializeField] private DeckData _deckData;

    private List<CardData> _deckList = new List<CardData>();
    private List<CardData> _deckToDisplayList = new List<CardData>();

    private void Start()
    {
        if (_deckData == null)
        {
            Debug.LogError("You have not DeckData !");
            return;
        }
        _deckList = _deckData.CardDataList;
        if (_deckList.Count == 0)
        {
            Debug.LogError("Asset is not create in DeckData !");
            return;
        }
        
        DrawCards();
        DisplayCardDataList(_deckToDisplayList);
    }
    
    private void DrawCards()
    {
        for (int i = 0; i < 7; i++)
        {
            int randomInt = UnityEngine.Random.Range(0, _deckList.Count);
            _deckToDisplayList.Add(_deckList[randomInt]);
            _deckList.RemoveAt(randomInt);
        }
    }

    private void DisplayCardDataList(List<CardData> cardDataList)
    {
        foreach (CardData cardItem in cardDataList)
        {
            Debug.Log(cardItem.CardValue.ToString() + " " + cardItem.CardSign.ToString());
        }
    }
}
