using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public AudioSource CollectSound;
    public GameObject PickUp;
    // Sets Score to 0
    void Start()
    {
        Scoring.Score = 0;
    }

    // When something has collided with the star, adds 100 to score
    void OnTriggerEnter(Collider other)
    {
        CollectSound.Play();
        // Previous Script
        //  Score.Score += 100;

        Scoring.Score += PickUp.GetComponent<Pickup>().GetPickedUp();
        GetComponent<Pickup>().GetPickedUp();
        Destroy(GetComponent<CapsuleCollider>());
        //Delays the destruction of pickup by 1 second
        Invoke("DestroyPickup", 1);
    }

    // Destorys pickup
    void DestroyPickup()
    {
        Destroy(gameObject);
        Debug.Log(gameObject.name +" has been destroyed");
    }
}
