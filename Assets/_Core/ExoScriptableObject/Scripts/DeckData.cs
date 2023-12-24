using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(DeckData), menuName = "ExoSciptableObject/Deck Data")]
public class DeckData : ScriptableObject
{
    [SerializeField] private List<CardData> _cardDataList = new List<CardData>();
    
    public List<CardData> CardDataList => _cardDataList;

    private void OnEnable()
    {
        AddCardDataAssetInDeck();
    }

    [ContextMenu("Add CardData Asset In Deck")]
    public void AddCardDataAssetInDeck()
    {
        _cardDataList.Clear();
        string[] AssetPath = AssetDatabase.FindAssets("t:CardData");
        if (AssetPath.Length == 0)
        {
            Debug.LogError("Asset is not create !");
        }
        else
        {
            foreach (string path in AssetPath)
            {
                _cardDataList.Add(AssetDatabase.LoadAssetAtPath<CardData>(AssetDatabase.GUIDToAssetPath(path)));
            }
        }
    }

    [MenuItem("Tools/Create Asset From Deck")]
    public static void CreateAssetFromDeck()
    {
        string path = "Assets/_Core/ExoScriptableObject";
        string folderName = "ScriptableObject_Data";
        
        AssetDatabase.DeleteAsset(path + "/" + folderName);
        AssetDatabase.CreateFolder(path, folderName);
        foreach (object sign in Enum.GetValues(typeof(Sign)))
        {
            AssetDatabase.CreateFolder(path + "/" + folderName, sign.ToString() + "s");
        }
        AssetDatabase.Refresh();
        
        for (int i = 0; i < Enum.GetValues(typeof(Sign)).Length; i++)
        { 
            for (int j = 0; j < Enum.GetValues(typeof(Value)).Length; j++)
            {
                CardData newCardAssetInstance = CardData.CreateInstance<CardData>();
                newCardAssetInstance.CardValue = (Value)j;
                newCardAssetInstance.CardSign = (Sign)i;
                
                AssetDatabase.CreateAsset(newCardAssetInstance, path + "/" + folderName + "/" + newCardAssetInstance.CardSign.ToString() + "s/" + newCardAssetInstance.CardValue.ToString() + "_" + newCardAssetInstance.CardSign.ToString() + ".asset");
            }
        }
    }
}
