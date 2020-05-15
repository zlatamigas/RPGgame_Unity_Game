using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    public Transform player;
    public GameObject hp;
    public float uron;
    public int health = 100;
    void Update()
    {
        transform.LookAt(player.position);
        if (Vector3.Distance(player.transform.position, transform.position) >= 5)
            GetComponent<NavMeshAgent>().enabled = false;
        if (Vector3.Distance(player.transform.position, transform.position) < 5)
        {
            GetComponent<NavMeshAgent>().enabled = true;
            GetComponent<NavMeshAgent>().destination = player.transform.position;
        }
        if (Vector3.Distance(player.transform.position, transform.position) <= 2f)
            GetComponent<NavMeshAgent>().enabled = false;
        if (Vector3.Distance(player.transform.position, transform.position) < 2f)
        {
            GetComponentInChildren<Animator>().SetTrigger("Атака");
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            hp.GetComponent<Slider>().value -= 5;
    }
}