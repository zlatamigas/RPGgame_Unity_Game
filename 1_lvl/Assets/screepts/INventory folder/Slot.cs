using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite activeCell;
    Sprite cell;
    Image img;
    void Start()
    {
        img = GetComponent<Image>();
        cell = img.sprite;
    }
    private void OnDisable()
    {
        img.sprite = cell;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        img.sprite = activeCell;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        img.sprite = cell;
    }   
}
