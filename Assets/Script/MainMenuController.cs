using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Created by Noel");
        SceneManager.LoadScene("Game");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by Noel");
    }
}
