using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class CardInstanciator : MonoBehaviour
{
    private List<CardData> _deckList;

    private void Start()
    {
        DrawCards(7);
        DisplayDeck();
    }

    private void DrawCards(int numberCardDrawn)
    {
        _deckList = new List<CardData>();
        while (_deckList.Count < numberCardDrawn)
        {
            CardData newCardData = GenerateCard();
            foreach (CardData cardItem in _deckList)
            {
                if (cardItem.CardValue == newCardData.CardValue && cardItem.CardSign == newCardData.CardSign)
                {
                    return;
                }
            }
            _deckList.Add(newCardData);
        }
    }
    
    private void DisplayDeck()
    {
        foreach (CardData cardItem in _deckList)
        {
            Debug.Log(cardItem.CardValue.ToString() + " " + cardItem.CardSign.ToString());
        }
    }

    private CardData GenerateCard()
    {
        CardData newCardItem = CardData.CreateInstance<CardData>();
        newCardItem.CardValue = (Value)Random.Range(0, Enum.GetValues(typeof(Value)).Length);
        newCardItem.CardSign = (Sign)Random.Range(0, Enum.GetValues(typeof(Sign)).Length);
        return newCardItem;
    }

    [ContextMenu("Create Asset From Deck")]
    private void CreateAssetFromDeck()
    {
        if (_deckList != null)
        {
            AssetDatabase.DeleteAsset("Assets/_Core/ExoScriptableObject/SciptableObject_Data");
            AssetDatabase.CreateFolder("Assets/_Core/ExoScriptableObject", "SciptableObject_Data");
            AssetDatabase.Refresh();
            foreach (CardData cardItem in _deckList)
            {
                AssetDatabase.CreateAsset(cardItem, "Assets/_Core/ExoScriptableObject/SciptableObject_Data/" + cardItem.CardValue.ToString() + "_" + cardItem.CardSign.ToString() + ".asset");
            }
        }
        else
        {
            Debug.LogError("You did not draw your 7 cards !");
        }
    }
}
