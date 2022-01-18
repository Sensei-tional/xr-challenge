using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private bool IsPaused;
    public GameObject PauseMenu, GameUI;
    public Button ResumeButton, TitleButton, QuitButton;
    
    // Start is called before the first frame update
    void Start()
    {
        GameUI.SetActive(true);
        PauseMenu.SetActive(false);
        IsPaused = false;

        // Listeners for each button in start menu
        ResumeButton.onClick.AddListener(ResumePlay);
        TitleButton.onClick.AddListener(MainMenu);
        QuitButton.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }

    // Toggle PauseGame
    void PauseGame()
    {
        if (Input.GetButtonDown("Cancel") && IsPaused == false)
        {
            GameUI.SetActive(false);
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
            IsPaused = true;
            Debug.Log("Game Paused");
        }
        else if (Input.GetButtonDown("Cancel") && IsPaused == true)
        {
            GameUI.SetActive(true);
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
            IsPaused = false;
            Debug.Log("Game Unpaused");
        }
    }

    // What happens when play is resumed
    void ResumePlay()
    {
        IsPaused = false;
        GameUI.SetActive(true);
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    // what happens when player wants to return to menu
    void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }

    //What happens when player wants to quit game
    void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
