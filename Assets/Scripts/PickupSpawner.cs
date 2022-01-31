using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public GameObject PickUp;
    private int SpawnLoop = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (SpawnLoop < 5)
        {
            SpawnPickup();
            SpawnLoop++;
        }
    }

    void SpawnPickup()
    {
        Vector3 SpawnLoc = new Vector3(Random.Range(-3.69f, 3.7f), 0f, Random.Range(3.77f, -3.63f));
        Instantiate(PickUp, SpawnLoc, PickUp.transform.rotation);
    }
}
