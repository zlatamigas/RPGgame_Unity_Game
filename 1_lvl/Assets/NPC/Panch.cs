using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panch : MonoBehaviour
{
    public KeyCode key;
    public string nameofAnim;
    public bool isanim = false;
    void Start()
    {
        gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            if (key == KeyCode.A)
                isanim = true;
            if (key == KeyCode.L)
            {
                gameObject.SetActive(true);
            }
            gameObject.GetComponent<Animator>().SetTrigger(nameofAnim);
        }
    }
}
