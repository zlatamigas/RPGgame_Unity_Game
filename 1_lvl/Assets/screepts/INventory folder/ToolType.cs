using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToolType : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    Inventory inventory;
    private void OnDisable()
    {
        inventory.toolTypeobj.SetActive(false);
    }
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory Manager").GetComponent<Inventory>();
    }
    void Update()
    {
        inventory.toolTypeobj.transform.position = new Vector2(Input.mousePosition.x + inventory.offsetX, Input.mousePosition.y + inventory.offsetY);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Currentitem currentItem = GetComponent<Currentitem>();
        Item item = inventory.item[currentItem.index];
        if (item.id != 0)
        {
            inventory.toolTypeobj.SetActive(true);
            inventory.icon.sprite = item.Icon;
            inventory.itemName.text = item.nameItem;
            inventory.description.text = item.descriptionItem;
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        inventory.toolTypeobj.SetActive(false);
    }
}
