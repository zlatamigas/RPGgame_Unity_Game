using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class predScrol : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(RollCredits());
    }
    IEnumerator RollCredits()
    {
        yield return new WaitForSeconds(19);
        SceneManager.LoadScene(1);
    }
}
