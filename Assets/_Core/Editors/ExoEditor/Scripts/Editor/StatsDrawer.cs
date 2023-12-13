using System.Reflection;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Stats))]
public class StatsDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        SerializedProperty healthProp = property.FindPropertyRelative("healthValue");
        RangeAttribute healthRangeAttribute = typeof(Stats).GetField(nameof(Stats.healthValue)).GetCustomAttribute<RangeAttribute>();
        
        EditorGUI.PropertyField(new Rect(1, EditorGUIUtility.singleLineHeight * 2, position.width, 20), healthProp);
        
        EditorGUI.ProgressBar(new Rect(5, EditorGUIUtility.singleLineHeight * 3, position.width - 6, 15),
            healthProp.intValue / healthRangeAttribute.max,
            "Health " + "(" + healthProp.intValue + "/" + healthRangeAttribute.max + ")");
        
        SerializedProperty manaProp = property.FindPropertyRelative("manaValue");
        RangeAttribute manaRangeAttribute = typeof(Stats).GetField(nameof(Stats.manaValue)).GetCustomAttribute<RangeAttribute>();
        
        EditorGUI.PropertyField(new Rect(1, EditorGUIUtility.singleLineHeight * 4, position.width, 20), manaProp);
        
        EditorGUI.ProgressBar(new Rect(5, EditorGUIUtility.singleLineHeight * 5, position.width - 6, 15), 
            manaProp.intValue / manaRangeAttribute.max, 
            "Mana " + "(" + manaProp.intValue + "/" + manaRangeAttribute.max + ")");
            
        position.y += EditorGUIUtility.singleLineHeight;
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUIUtility.singleLineHeight * 5;
    }
}