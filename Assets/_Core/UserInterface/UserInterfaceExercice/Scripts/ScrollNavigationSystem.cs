using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(ScrollRect))]
public class ScrollNavigationSystem : MonoBehaviour
{
    [SerializeField] private RectTransform _contentParentRectTransform;
    private GameObject _selectedGameObject;
    private ScrollRect _scrollRectInventory;

    private void Awake()
    {
        _scrollRectInventory = GetComponent<ScrollRect>();
    }

    private void Update()
    {
        _selectedGameObject = EventSystem.current.currentSelectedGameObject;

        if (_selectedGameObject.transform.IsChildOf(_contentParentRectTransform))
        {
            float selectedIndexFromParent = _selectedGameObject.transform.GetSiblingIndex();
            float childCountParent = _contentParentRectTransform.transform.childCount;

            _scrollRectInventory.verticalNormalizedPosition = 1 - selectedIndexFromParent / (childCountParent - 1);
        }
    }
}
