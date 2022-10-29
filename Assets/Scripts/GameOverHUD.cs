using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverHUD : MonoBehaviour
{
   
    public void RestartGame()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Level01");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
