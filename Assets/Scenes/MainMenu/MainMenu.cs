using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Игра смогла запустить себя");
        SceneManager.LoadScene("Lobby");
    }

    public void ExitGame()
    {
        Debug.Log("Игра кильнула себя");
        Application.Quit();
    }
}
