using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void gameControls()
    {
        SceneManager.LoadScene(1);
    }

    public void backButton()
    {
        SceneManager.LoadScene(0);
    }
}
