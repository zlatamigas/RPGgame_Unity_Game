using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollCredits : MonoBehaviour
{

    public GameObject creditRun;
    void Start()
    {
        StartCoroutine(RollCredits());
    }
    IEnumerator RollCredits()
    {
        yield return new WaitForSeconds(0.5f);
        creditRun.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
