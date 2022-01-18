using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    // Allows for the camera to follow player
    void FollowPlayer()
    {
            Vector3 PlayerPos = new Vector3(Player.transform.position.x, Player.transform.position.y + 5.62f, Player.transform.position.z - 1.47f);
            transform.position = PlayerPos;
    }
}
