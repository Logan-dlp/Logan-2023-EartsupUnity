using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CardInstanciator : MonoBehaviour
{
    [SerializeField] private List<CardData> _deckList;
    private List<CardData> _playerDeckList = new List<CardData>();

    private void Awake()
    {
        CreateAssetFromDeck();
    }

    private void Start()
    {
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
        string path = "Assets/_Core/ExoScriptableObject";
        string folderName = "ScriptableObject_Data";
        
        AssetDatabase.DeleteAsset(path + "/" + folderName);
        AssetDatabase.CreateFolder(path, folderName);
        AssetDatabase.Refresh();
        _deckList = new List<CardData>();

        foreach (object sign in Enum.GetValues(typeof(Sign)))
        {
            AssetDatabase.CreateFolder(path + "/" + folderName, sign.ToString() + "s");
            AssetDatabase.Refresh();
        }
        
        for (int i = 0; i < Enum.GetValues(typeof(Sign)).Length; i++)
        { 
            for (int j = 0; j < Enum.GetValues(typeof(Value)).Length; j++)
            {
                CardData newCardAssetInstance = CardData.CreateInstance<CardData>();
                newCardAssetInstance.CardValue = (Value)j;
                newCardAssetInstance.CardSign = (Sign)i;
                _deckList.Add(newCardAssetInstance);
                
                AssetDatabase.CreateAsset(newCardAssetInstance, path + "/" + folderName + "/" + newCardAssetInstance.CardSign.ToString() + "s/" + newCardAssetInstance.CardValue.ToString() + "_" + newCardAssetInstance.CardSign.ToString() + ".asset");
            }
        }
    }
}
