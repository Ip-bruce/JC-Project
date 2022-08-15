using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 velocity;
    private Vector3 playerMovementInput;
    private Vector2 playerMouseInput;
    private float xRot;

    [SerializeField] private Transform playerCamera;
    [SerializeField] private CharacterController controller;
    [Space]
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float sensitivity;
    [SerializeField] private float gravity = -9.81f; 

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        playerMouseInput = new Vector2(Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"));
        playerMovementInput = new Vector3(Input.GetAxis("Horizontal"),0f,Input.GetAxis("Vertical"));
        MovePlayer();
        MovePlayerCamera();

    }

    void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(playerMovementInput);  
        
        if(controller.isGrounded)
        {
            velocity.y = -1f;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                velocity.y = jumpForce;
            }
        }
        else
        {
            velocity.y -= gravity * -2f * Time.deltaTime;
        }

        controller.Move(MoveVector * speed * Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);
    }

    void MovePlayerCamera()
    {
        xRot = Mathf.Clamp(xRot, -90f, 90f); 
        xRot -= playerMouseInput.y * sensitivity;
        transform.Rotate(0f,playerMouseInput.x * sensitivity,0);
        playerCamera.transform.localRotation = Quaternion.Euler(xRot,0f,0f);
    }


}
