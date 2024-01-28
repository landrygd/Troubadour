using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
  public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void StartCredits()
    {
        SceneManager.LoadScene("credits");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
