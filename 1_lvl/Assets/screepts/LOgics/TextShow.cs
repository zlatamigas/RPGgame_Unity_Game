using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextShow : MonoBehaviour
{
    public GameObject panel;
    public GameObject pig;
    void Start()
    {
        panel.SetActive(false);
    }
    void Update()
    {
        if (pig.GetComponent<Panch>().isanim)
            panel.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            panel.SetActive(true);
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            panel.SetActive(false);
    }
}
