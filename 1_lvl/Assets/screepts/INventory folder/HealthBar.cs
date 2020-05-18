using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int currentLevel = 1;
    public GameObject pers;
    public GameObject two_lvl;
    public GameObject three_lvl;
    public GameObject four_lvl;
    public void AddHealth(int value)
    {
        GetComponent<Slider>().value += value;
    }
    private void Update()
    {
        if (GetComponent<Slider>().value <= 0)
        {
            switch (currentLevel)
            {
                case 1:
                    SceneManager.LoadScene(1);
                    break;
                case 2:
                    pers.transform.position = two_lvl.transform.position + new Vector3(1,1,1);
                    break;
                case 3:
                    pers.transform.position = three_lvl.transform.position + new Vector3(1, 1, 1);
                    break;
                case 4:
                    pers.transform.position = four_lvl.transform.position + new Vector3(1, 1, 1);
                    break;
                default:
                    Debug.Log("error==)))");
                    break;
            }
        }
    }
}
