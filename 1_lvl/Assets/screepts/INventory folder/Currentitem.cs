using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Currentitem : MonoBehaviour, IPointerClickHandler , IDropHandler
{
    public int index;
    GameObject inventoryObj;
    Inventory inventory;
    void Start()
    {
        inventoryObj = GameObject.FindGameObjectWithTag("Inventory Manager");
        inventory = inventoryObj.GetComponent<Inventory>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (inventory.item[index].customEvent != null)
            {
                inventory.item[index].customEvent.Invoke();
            }
            if (inventory.item[index].isRemovebool)
            {
                Remove();
            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (inventory.item[index].isDroped)
            {
                Drop();
                Remove();
            }
        }
    }
    public void Remove()
    {
        if (inventory.item[index].id != 0)
        {
            if (inventory.item[index].countItem > 1)
                inventory.item[index].countItem--;
            else
                inventory.item[index] = gameObject.AddComponent<Item>();
            inventory.DisplayItem();
        }
    }
    public void Drop()
    {
        if (inventory.item[index].id != 0)
        {
            for (int i = 0; i < inventory.dataBase.transform.childCount; i++)
            {
                Item item = inventory.dataBase.transform.GetChild(i).GetComponent<Item>();
                if (item)
                {
                    if (inventory.item[index].id == item.id)
                    {
                        GameObject droped = Instantiate(item.gameObject);
                        droped.transform.position = Camera.main.transform.position + Camera.main.transform.forward;
                    }
                }
            }

        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dragedObjk = Drag.drgedObj;
        if (dragedObjk == null)
            return;

        Currentitem currentDragetItem = dragedObjk.GetComponent<Currentitem>();
        if (currentDragetItem != null)
        {
            Item currentItem = inventory.item[GetComponent<Currentitem>().index];
            inventory.item[GetComponent<Currentitem>().index] = inventory.item[currentDragetItem.index];
            inventory.item[currentDragetItem.index] = currentItem;
            inventory.DisplayItem();
        }
    }
}