using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public new GameObject light;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            light.SetActive(!light.activeSelf);
        }
    }
}
