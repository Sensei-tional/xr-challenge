using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float offset = 6.2f;

    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    // Allows for the camera to follow player
    void FollowPlayer()
    {
            Vector3 PlayerPos = new Vector3(Player.transform.position.x, Player.transform.position.y + offset, Player.transform.position.z - 1.47f);
            transform.position = PlayerPos;
    }
}
