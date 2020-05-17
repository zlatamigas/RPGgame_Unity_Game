using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    public string nameItem;
    public int id;
    [HideInInspector]
    public int countItem;
    public bool isStakeable;
    [Multiline(5)]
    public string descriptionItem;
    public Sprite Icon;
    public bool isDroped;
    public bool isRemovebool;
    public UnityEvent customEvent;
}
