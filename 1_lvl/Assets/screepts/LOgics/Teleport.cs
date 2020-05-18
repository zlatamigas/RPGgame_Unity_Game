using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject hero;
    public GameObject pointTeleport;
    public GameObject bar;
    public int curlvl;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Playerhand"))
        {
            hero.transform.position = pointTeleport.transform.position + new Vector3(1,1,1);
            bar.GetComponent<HealthBar>().currentLevel = curlvl;
        }
    }
}
