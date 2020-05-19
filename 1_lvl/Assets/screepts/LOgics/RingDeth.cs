using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingDeth : MonoBehaviour
{
  public void Boom(GameObject corol)
    {
        corol.GetComponent<Enemy>().health -= 80;
    }
}
