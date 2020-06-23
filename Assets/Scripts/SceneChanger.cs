using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("2StartScene");
    }
    public void playGame()
    {
        SceneManager.LoadScene("4MapScene");
    }
    public void settingsMenu()
    {
        SceneManager.LoadScene("3SettingsScene");
    }
    public void goToMenu()
    {
        SceneManager.LoadScene("1MenuScene");
    }
    public void goToCredits()
    {
        SceneManager.LoadScene("5CreditsScene");
    }
    public void quit()
    {
        Application.Quit();
    }
}
