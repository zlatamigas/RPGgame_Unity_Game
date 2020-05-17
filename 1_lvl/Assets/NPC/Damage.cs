using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public int damtoEnemy;
    public int damtoHero;
    public GameObject hp;
    public string tego;
    void Start()
    {

    }
    void Update()
    {

    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Enemy") && tego != "Enemy")
            col.GetComponent<Enemy>().health -= damtoEnemy;
        if (col.CompareTag("Player"))
            hp.GetComponent<Slider>().value -= damtoHero;
    }
}
