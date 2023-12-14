using System.Reflection;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Stats))]
public class StatsDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // property intialize
        SerializedProperty healthProp = property.FindPropertyRelative("healthValue");
        RangeAttribute healthRangeAttribute = typeof(Stats).GetField(nameof(Stats.healthValue)).GetCustomAttribute<RangeAttribute>();
        
        SerializedProperty manaProp = property.FindPropertyRelative("manaValue");
        RangeAttribute manaRangeAttribute = typeof(Stats).GetField(nameof(Stats.manaValue)).GetCustomAttribute<RangeAttribute>();
        
        // property displayed
        Rect propertyPosition = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
        EditorGUI.PropertyField(propertyPosition, healthProp);
        
        propertyPosition = new Rect(propertyPosition.x, propertyPosition.y + EditorGUIUtility.singleLineHeight, propertyPosition.width, propertyPosition.height);
        EditorGUI.ProgressBar(propertyPosition,
            healthProp.intValue / healthRangeAttribute.max,
            "Health " + "(" + healthProp.intValue + "/" + healthRangeAttribute.max + ")");
        
        propertyPosition = new Rect(propertyPosition.x, propertyPosition.y + EditorGUIUtility.singleLineHeight, propertyPosition.width, propertyPosition.height);
        EditorGUI.PropertyField(propertyPosition, manaProp);
        
        propertyPosition = new Rect(propertyPosition.x, propertyPosition.y + EditorGUIUtility.singleLineHeight, propertyPosition.width, propertyPosition.height);
        EditorGUI.ProgressBar(propertyPosition, 
            manaProp.intValue / manaRangeAttribute.max, 
            "Mana " + "(" + manaProp.intValue + "/" + manaRangeAttribute.max + ")");
    }
    
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUIUtility.singleLineHeight * 4;
    }
}