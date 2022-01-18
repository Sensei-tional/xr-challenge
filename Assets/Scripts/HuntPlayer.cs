using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HuntPlayer : MonoBehaviour
{
    public GameObject Player;
    public int Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hunt();
    }

    void Hunt()
    {
        transform.LookAt(Player.transform.position);

        if (Vector3.Distance(transform.position, Player.transform.position) > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Title");
    }
}
