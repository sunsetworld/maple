using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] AudioClip HUDSound;

    public void playGame()
    {
        SceneManager.LoadScene("Level01");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void OpenInstructions()
    {
        SceneManager.LoadScene("instructions");
    }

    
}
