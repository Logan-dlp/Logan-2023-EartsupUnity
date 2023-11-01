using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CardInstanciator : MonoBehaviour
{
    [SerializeField] private List<CardData> _deckList;
    private List<CardData> _playerDeckList = new List<CardData>();

    private void Start()
    {
        CreateAssetFromDeck();
        DrawCards();
        DisplayDeck();
    }

    
    private void DrawCards()
    {
        for (int i = 0; i < 7; i++)
        {
            int randomInt = UnityEngine.Random.Range(0, _deckList.Count);
            _playerDeckList.Add(_deckList[randomInt]);
            _deckList.RemoveAt(randomInt);
        }
    }
    
    private void DisplayDeck()
    {
        foreach (CardData cardItem in _playerDeckList)
        {
            Debug.Log(cardItem.CardValue.ToString() + " " + cardItem.CardSign.ToString());
        }
    }
    
    [ContextMenu("Create Asset From Deck")]
    private void CreateAssetFromDeck()
    {
        AssetDatabase.DeleteAsset("Assets/_Core/ExoScriptableObject/ScriptableObject_Data");
        AssetDatabase.CreateFolder("Assets/_Core/ExoScriptableObject", "ScriptableObject_Data");

        foreach (object nameFolderObject in Enum.GetValues(typeof(Sign)))
        {
            AssetDatabase.CreateFolder("Assets/_Core/ExoScriptableObject/ScriptableObject_Data", nameFolderObject.ToString() + "s");
        }
        
        AssetDatabase.Refresh();
        _deckList = new List<CardData>();
        
        for (int i = 0; i < Enum.GetValues(typeof(Value)).Length; i++)
        { 
            for (int j = 0; j < Enum.GetValues(typeof(Sign)).Length; j++)
            {
                CardData newCardAssetInstance = CardData.CreateInstance<CardData>();
                newCardAssetInstance.CardValue = (Value)i;
                newCardAssetInstance.CardSign = (Sign)j;
                
                _deckList.Add(newCardAssetInstance);
                
                AssetDatabase.CreateAsset(newCardAssetInstance, "Assets/_Core/ExoScriptableObject/ScriptableObject_Data/" + newCardAssetInstance.CardSign.ToString() + "s/" + newCardAssetInstance.CardValue.ToString() + "_" + newCardAssetInstance.CardSign.ToString() + ".asset");
            }
        }
    }
}
