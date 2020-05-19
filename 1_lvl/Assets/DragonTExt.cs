using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonTExt : MonoBehaviour
{
    public GameObject panel;
    public GameObject panelka;
    public GameObject king;

    void Start()
    {
        panel.SetActive(false);
        panelka.SetActive(false);
        king.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            panelka.SetActive(true);
            king.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Playerhand"))
        {
            panel.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Playerhand"))
        {
            panel.SetActive(false);
        }
    }
}
