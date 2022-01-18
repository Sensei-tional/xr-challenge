using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [System.Serializable]
    public class MovementFW
    {
        public float Speed = 10;
        public float JumpForce = 25;
        public float isGrounded = 0.6f;
        public LayerMask ground;
    }

    [System.Serializable]
    public class InputFW
    { 
        public float StrafeInput, ForwardInput, JumpInput;
    }

    public MovementFW MoveVars = new MovementFW();
    public InputFW InputVars = new InputFW();


    // Speed variable along with inputs for WASD for movement
    public int Score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Move();
        Jump();
    }

    // Checks whether the player is Grounded
    bool Grounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, MoveVars.isGrounded, MoveVars.ground);
    }

    // Handles player movement
    void Move()
    {
        InputVars.StrafeInput = Input.GetAxis("Horizontal");
        InputVars.ForwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * MoveVars.Speed * InputVars.ForwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * MoveVars.Speed * InputVars.StrafeInput);
    }

    // Handles player jumping
    void Jump()
    {
        InputVars.JumpInput = Input.GetAxisRaw("Jump");

        if (InputVars.JumpInput > 0 && Grounded())
        {
            Debug.Log("Can Jump");
            GetComponent<Rigidbody>().AddForce(Vector3.up * MoveVars.JumpForce);
        }
        else if (InputVars.JumpInput == 0 && Grounded())
        {
            Debug.Log("Static");
        }
        else
        {
            Debug.Log("Can't Jump");
        }
    }
}
