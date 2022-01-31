using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour
{
    public GameObject ScoreText, ScoreCountText;
    public static int Score;

    void Start()
    {
        
    }

    // Handles score update and objectives displayed on UI
    void Update()
    {
        ScoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + Score;
        ScoreCountText.GetComponent<TextMeshProUGUI>().text = "Collect Stars: " + Score / 100 + "/5";
    }
}