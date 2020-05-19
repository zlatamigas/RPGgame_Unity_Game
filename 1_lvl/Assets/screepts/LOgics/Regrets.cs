using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Regrets : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(RollCredits());
    }
    IEnumerator RollCredits()
    {
        yield return new WaitForSeconds(12);
        SceneManager.LoadScene(0);
    }
}
