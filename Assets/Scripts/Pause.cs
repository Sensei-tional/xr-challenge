using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private bool IsPaused;
    public GameObject PauseMenu, GameUI;
    public Button ResumeButton, QuitButton, TitleButton;
    
    // Start is called before the first frame update
    void Start()
    {
        GameUI.SetActive(true);
        PauseMenu.SetActive(false);
        IsPaused = false;
        ResumeButton.onClick.AddListener(ResumePlay);
        TitleButton.onClick.AddListener(MainMenu);
        QuitButton.onClick.AddListener(QuitGame);
        
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }

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

    void ResumePlay()
    {
        GameUI.SetActive(true);
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        IsPaused = false;
        Debug.Log("Game Paused");
    }

    void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }

    void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
