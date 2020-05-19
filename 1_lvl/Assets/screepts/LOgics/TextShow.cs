using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextShow : MonoBehaviour
{
    public GameObject panel;
    public GameObject panelka;
    public GameObject king;
    public GameObject pig;
    void Start()
    {
        panel.SetActive(false);
    }
    void Update()
    {
        if (pig.GetComponent<Panch>().isanim)
            panel.SetActive(false);
        if (Input.GetKeyDown(KeyCode.L))
        {
            panelka.SetActive(true);
            king.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Playerhand"))
            panel.SetActive(true);
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Playerhand"))
            panel.SetActive(false);
    }
}
