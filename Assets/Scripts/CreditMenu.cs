using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CreditMenu : MonoBehaviour
{
    public Button CreditButton;
    public GameObject CreditButtonText;
    // Start is called before the first frame update
    void Start()
    {
        CreditButtonText.GetComponent<TextMeshProUGUI>().text = "Back";
        CreditButton.onClick.AddListener(ReturnToStart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReturnToStart()
    {
        SceneManager.LoadScene("Title");
    }
}
