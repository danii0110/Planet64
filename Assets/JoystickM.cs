using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class JoystickM : MonoBehaviour, IBeginDragHandler, IDragHandler   //���̽�ƽ ����
{
    [SerializeField]
    private RectTransform lever;
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        var inputPos = eventData.position ;
        lever.anchoredPosition = inputPos;
    }

    public void OnDrag(PointerEventData eventData)
    {
        var inputPos = eventData.position ;
        lever.anchoredPosition = inputPos;
    }

}
    

    