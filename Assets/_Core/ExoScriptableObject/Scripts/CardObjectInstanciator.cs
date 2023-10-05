using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CardObjectInstanciator : MonoBehaviour
{
    private List<string> _cardInInventoryList = new List<string>();
    
    private void Start()
    {
        
        for (int i = 0; i < 7; i++)
        {
            string randomCard = CreateRandomCard();
            bool cardInInventory = false;
            foreach (string card in _cardInInventoryList)
            {
                if (randomCard == card)
                {
                    cardInInventory = true;
                    break;
                }
            }

            if (!cardInInventory)
            {
                _cardInInventoryList.Add(randomCard);
                Debug.Log(randomCard);
            }
            else
            {
                Debug.Log("meme carte");
                i--;
            }
        }
    }

    private string CreateRandomCard()
    {
        Card newCard = Card.CreateInstance<Card>();
        
        string cardSignInstance = newCard.CardSign[Random.Range(0, newCard.CardSign.Length)];
        string cardValueInstance = newCard.CardValue[Random.Range(0, newCard.CardValue.Length)];
        
        return cardValueInstance + " de " + cardSignInstance;
    }
}
