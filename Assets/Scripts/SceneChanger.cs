using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void playGame()
    {
        SceneManager.LoadScene("MapScene");
    }
    public void settingsMenu()
    {
        SceneManager.LoadScene("SettingsScene");
    }
    public void goToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void quit()
    {
        Application.Quit();
    }
}
