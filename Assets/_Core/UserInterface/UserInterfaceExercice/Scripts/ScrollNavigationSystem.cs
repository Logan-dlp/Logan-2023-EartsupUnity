using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(ScrollRect))]
public class ScrollNavigationSystem : MonoBehaviour
{
    private GameObject _selectedGameObject;
    private ScrollRect _scrollRectInventory;
    [SerializeField] private RectTransform _contentParent;

    private void Start()
    {
        _scrollRectInventory = GetComponent<ScrollRect>();
    }

    private void Update()
    {
        _selectedGameObject = EventSystem.current.currentSelectedGameObject;

        if (_selectedGameObject.transform.IsChildOf(_contentParent))
        {
            _scrollRectInventory.verticalNormalizedPosition = 1 - (float)_selectedGameObject.transform.GetSiblingIndex() /
                                                          (_contentParent.transform.childCount - 1);
        }
    }
}
