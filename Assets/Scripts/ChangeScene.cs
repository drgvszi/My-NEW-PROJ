using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void startGame()
    {
        SceneManager.LoadScene("StartScene");
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
