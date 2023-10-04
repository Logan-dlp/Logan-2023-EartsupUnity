using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CardObjectInstanciator : MonoBehaviour
{
    private void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            string randomCardInstance = CreateRandomCard();
            Debug.Log(randomCardInstance);
        }
    }

    private string CreateRandomCard()
    {
        Card newCard = Card.CreateInstance<Card>();
        
        string cardSignInstance = newCard.CardSign[Random.Range(0, newCard.CardSign.Length)];
        string cardValueInstance = newCard.CardValue[Random.Range(0, newCard.CardValue.Length)];
        
        return cardValueInstance + " " + cardSignInstance;
    }
}
