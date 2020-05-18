using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panch : MonoBehaviour
{
    public KeyCode key;
    public string nameofAnim;
    public bool isanim = false;
    public GameObject sworsI;
    public GameObject telPort;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            if (key == KeyCode.B)
            {
                isanim = true;
                sworsI.SetActive(true);
                telPort.SetActive(true);
            }
            gameObject.GetComponent<Animator>().SetTrigger(nameofAnim);
        }
    }
}
