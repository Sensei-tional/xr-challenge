using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Speed variable along with inputs for WASD for movement
    public float Speed;
    public float StrafeInput, ForwardInput;
    public int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") > 0 && Input.GetAxis("Jump") < 0.0001)
            if (transform.position.y < 0.6f)
            {
                Debug.Log("Jump");
            }
    }

    void FixedUpdate()
    {
        StrafeInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * Speed * ForwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * Speed * StrafeInput);
    }
}
