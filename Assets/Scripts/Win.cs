using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Win : MonoBehaviour
{
    public bool WinToggle = false;
    public GameObject FinishSpace, WinText;
    // Start is called before the first frame update
    void Start()
    {
        WinText.GetComponent<TextMeshProUGUI>().text = "";
    }

    // Update is called once per frame
    void Update()
    {

        if (Scoring.Score == 500 && WinToggle == false)
        {
            WinCon();
        }
    }

    // Complete object
    public void WinCon()
    {
        WinText.GetComponent<TextMeshProUGUI>().text = "You have collected all stars! Move to the green cube!";
        Vector3 spawnPos = new Vector3(3.15f, 0.5f, 0f);
        Instantiate(FinishSpace, spawnPos, FinishSpace.transform.rotation);
        WinToggle = true;
    }

}
