using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusic : MonoBehaviour
{
    public void Switch()
    {
        if (gameObject.GetComponent<AudioSource>().isPlaying)
            gameObject.GetComponent<AudioSource>().Pause();
        else
            gameObject.GetComponent<AudioSource>().Play();
    }
}
