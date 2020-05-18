using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;
    void Start()
    {
    }
    public void PlayGame()
    {
        buttonPress.Play();
        SceneManager.LoadScene(3);
    }
    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }
    public void Credits()
    {
        buttonPress.Play();
        SceneManager.LoadScene(2);
    }
}