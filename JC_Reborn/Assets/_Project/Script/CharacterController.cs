using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class CharacterController : MonoBehaviour
{
    Rigidbody rb;
    public  float moveH;
    public  float moveV;
    public  float y;
    Vector3 movement;
    public  float moveSpeed;
    public float Mousex;
    public float lookSpeed = 3f;
    public float jumpSpeed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PcController();
    }

    public void PcController()
    {
       moveH = Input.GetAxis("Horizontal");
       moveV = Input.GetAxis("Vertical");
       //movement = (moveH,y,moveV);
       //rb.AddForce(movement.x * moveSpeed);

       if(Input.GetKey(KeyCode.W))
       {  
            transform.Translate(0,0,moveV * moveSpeed * Time.deltaTime);
            transform.Rotate(0 ,moveH * moveSpeed ,0);
       }

        transform.Translate( moveH * moveSpeed * Time.deltaTime,0,moveV * moveSpeed * Time.deltaTime);
        transform.Rotate(0 ,moveH * moveSpeed ,0);

        //Camera Controls
        Mousex = Input.GetAxis("Mouse X");
        // Mousey = Input.GetAxis("MouseY");

       // transform.Rotate(0,Mousex * lookSpeed ,0);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpSpeed);
            Debug.Log("Jump!!!!!");
        }
    }

    // public void GamePad()
    // {

    // }
}
