using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public GameObject StartButtonText, CreditButtonText;
    public Button StartButton, CreditButton;
    // Start is called before the first frame update
    void Start()
    {
        StartButtonText.GetComponent<TextMeshProUGUI>().text = "Start";
        CreditButtonText.GetComponent<TextMeshProUGUI>().text = "Credit";
        StartButton.onClick.AddListener(MainOnClick);
        CreditButton.onClick.AddListener(CreditOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MainOnClick()
    {
        SceneManager.LoadScene("Main");
    }

    void CreditOnClick()
    {
        SceneManager.LoadScene("Credit");
    }
}
