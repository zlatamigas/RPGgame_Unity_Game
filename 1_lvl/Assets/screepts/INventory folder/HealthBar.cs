using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int currentLevel;
    public void AddHealth(int value)
    {
        GetComponent<Slider>().value += value;
    }
    private void Update()
    {
        if (GetComponent<Slider>().value <= 0)
        {
            SceneManager.LoadScene(currentLevel);
        }
    }
}
