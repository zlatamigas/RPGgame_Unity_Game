using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public void SwitchFlash(GameObject flash)
    {
        flash.SetActive(!flash.activeSelf);
    }
}
