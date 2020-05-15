using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Inventory : MonoBehaviour
{
    [HideInInspector]
    public List<Item> item;
    private List<Item> dataItem;
    public GameObject cellConainer;
    [Header("Messages")]
    public GameObject messManager;
    public GameObject message;
    public FirstPersonController player;
    public GameObject point;
    public GameObject dataBase;
    [Header("toolType")]
    public GameObject toolTypeobj;
    public Image icon;
    public Text itemName;
    public Text description;
    public float offsetX;
    public float offsetY;
    [Header("drag")]
    public GameObject dragPrefab;


    void Start()
    {
        toolTypeobj.SetActive(false);
        for (int i = 0; i < cellConainer.transform.childCount; i++)
        {
            cellConainer.transform.GetChild(i).GetComponent<Currentitem>().index = i;
        }
        cellConainer.SetActive(false);
        if (dataItem.Count !=0)
        {
            item = dataItem;
        }
        else
        {
            item = new List<Item>();            
            for (int i = 0; i < cellConainer.transform.childCount; i++)
            {
                item.Add(new Item());
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (cellConainer.activeSelf)
            {
                cellConainer.SetActive(false);
                player.enabled = true;
                point.SetActive(true);
            }
            else
            {
                cellConainer.SetActive(true);
                player.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                point.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            if (Physics.Raycast(ray, out RaycastHit hit, 10f))
                if (hit.collider.GetComponent<Item>())
                {
                    Item curitem = hit.collider.GetComponent<Item>();
                    MessageEnter(curitem);
                    AddItem(hit.collider.GetComponent<Item>());
                    dataItem = item;
                }                    
        }
    }
    void MessageEnter(Item current)
    {
        GameObject mess = Instantiate(message);
        mess.transform.SetParent(messManager.transform);
        Image img = mess.transform.GetChild(0).GetComponent<Image>();
        img.sprite = current.Icon;
        Text msg = mess.transform.GetChild(1).GetComponent<Text>();
        msg.text = current.nameItem;
    }
    void AddItem(Item cur)
    {
        if (cur.isStakeable)
            AddStakeble(cur);
        else
            AddUNstakebl(cur);
    }
    void AddUNstakebl(Item currentItem)
    {
        for (int i = 0; i < item.Count; i++)
            if (item[i].id == 0)
            {
                item[i] = currentItem;
                item[i].countItem = 1;
                DisplayItem();
                Destroy(currentItem.gameObject);
                break;
            }
    }
    void AddStakeble(Item current)
    {
        for (int i = 0; i < item.Count; i++)
            if (item[i].id == current.id)
            {
                item[i].countItem++;
                DisplayItem();
                Destroy(current.gameObject);
                return;
            }
        AddUNstakebl(current);
    }
    public void DisplayItem()
    {
        for (int i = 0; i < item.Count; i++)
        {
            Transform cell = cellConainer.transform.GetChild(i);
            Transform icon = cell.GetChild(0);
            Transform count = icon.GetChild(0);
            Image image = icon.GetComponent<Image>();
            Text txt = count.GetComponent<Text>();
            if (item[i].id != 0)
            {
                image.enabled = true;
                image.sprite = item[i].Icon;
                if (item[i].countItem > 1)
                    txt.text = item[i].countItem.ToString();
                else
                    txt.text = null;
            }
            else
            {
                image.enabled = false;
                image.sprite = null;
                txt.text = null;
            }
        }
    }
}
