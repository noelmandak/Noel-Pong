using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void BactToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by Noel");
    }
}
