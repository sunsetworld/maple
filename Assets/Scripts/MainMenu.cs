using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] AudioClip HUDSound;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            playGame();
        }
    }
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
