using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame ()
    {
        Debug.Log("Starting Game");
        SceneManager.LoadScene(1);
    }

    public void QuitGame ()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void OptionsOpen ()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
