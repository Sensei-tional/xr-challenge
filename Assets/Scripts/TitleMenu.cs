using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public Button StartButton, CreditButton, QuitButton;
    // Start is called before the first frame update
    void Start()
    {
        // Adds listeners to buttons
        StartButton.onClick.AddListener(MainOnClick);
        CreditButton.onClick.AddListener(CreditOnClick);
        QuitButton.onClick.AddListener(QuitOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MainOnClick()
    {
        // Load main scene
        SceneManager.LoadScene("Main");
    }

    void CreditOnClick()
    {
        // Load credits scene
        SceneManager.LoadScene("Credit");
    }

    void QuitOnClick()
    {
        // Stops game whether in UnityEngine or built application
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
