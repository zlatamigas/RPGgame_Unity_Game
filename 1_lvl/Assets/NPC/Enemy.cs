using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    public Transform player;
    public int health;
    public string animName;
    void Update()
    {
        gameObject.transform.GetChild(1).GetComponent<TextMesh>().text = health.ToString();
        if (health <= 0)
            Destroy(gameObject);
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
            GetComponentInChildren<Animator>().SetTrigger(animName);
        }
    }
}