using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject hero;
    public Transform pointTeleport;
    public GameObject bar;
    public int curlvl;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bar.GetComponent<HealthBar>().currentLevel = curlvl;
            hero.transform.position = pointTeleport.position;

        }
    }
    
}
