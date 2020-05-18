using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Experianse : MonoBehaviour
{
    public int Exp = 0;
    void Start()
    {
        
    }
    void Update()
    {
        gameObject.GetComponent<Text>().text = Exp.ToString();
    }
}
