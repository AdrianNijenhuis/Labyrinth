using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private string gameplaySceneName = "GameplayScene1";
    
    public void QuitGame ()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void StartHost ()
    {
        Debug.Log("Starting Game");
        NetworkManager.Singleton.StartHost();
        Debug.Log("Starting Game 2");
        NetworkManager.Singleton.SceneManager.LoadScene(gameplaySceneName, LoadSceneMode.Single);
    }

    public void StartServer ()
    {
        NetworkManager.Singleton.StartServer();
        NetworkManager.Singleton.SceneManager.LoadScene(gameplaySceneName, LoadSceneMode.Single);
    }

    public void StartClient ()
    {
        NetworkManager.Singleton.StartClient();
    }

    public void StartGame ()
    {
        Debug.Log("Starting Game");
        SceneManager.LoadScene(1);
    }
}
