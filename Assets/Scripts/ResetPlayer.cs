using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public GameObject Player;
    public Vector3 PlayerLoc = new Vector3(0f, 1.49f, 0f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = PlayerLoc; 
    }
}

