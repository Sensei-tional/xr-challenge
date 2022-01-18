using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Runs NextLevel on collision
    void OnTriggerEnter(Collider other)
    {
        NextLevel();
    }

    // Loads next Level
    public void NextLevel()
    {
        string Level = SceneManager.GetActiveScene().name;
        if (Level == "Main")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (Level == "Level2")
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
