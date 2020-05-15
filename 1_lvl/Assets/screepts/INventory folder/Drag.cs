using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject drgedObj;
    Inventory inventory;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory Manager").GetComponent<Inventory>();
    }
    void Update()
    {

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        drgedObj = gameObject;
        inventory.dragPrefab.SetActive(true);
        inventory.dragPrefab.GetComponent<CanvasGroup>().blocksRaycasts = false;
        if (drgedObj.GetComponent<Currentitem>())
        {
            int index = drgedObj.GetComponent<Currentitem>().index;
            inventory.dragPrefab.GetComponent<Image>().sprite = inventory.item[index].Icon;
            if (inventory.item[index].countItem > 1)
            {
                inventory.dragPrefab.transform.GetChild(0).GetComponent<Text>().text = inventory.item[index].countItem.ToString();
            }
            else
            {
                inventory.dragPrefab.transform.GetChild(0).GetComponent<Text>().text = null;
            }
            if (inventory.dragPrefab.GetComponent<Image>().sprite == null)
            {
                drgedObj = null;
                inventory.dragPrefab.SetActive(false);
            }
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        inventory.dragPrefab.transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            drgedObj.GetComponent<Currentitem>().Drop();
            drgedObj.GetComponent<Currentitem>().Remove();
        }
        drgedObj = null;
        inventory.dragPrefab.SetActive(false);
        inventory.dragPrefab.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
