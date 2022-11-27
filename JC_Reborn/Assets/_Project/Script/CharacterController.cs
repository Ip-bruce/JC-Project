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
        transform.Translate(moveH * moveSpeed * Time.deltaTime,0,moveV * moveSpeed * Time.deltaTime);
        
        //Camera Controls
        Mousex = Input.GetAxis("Mouse X");
        // Mousey = Input.GetAxis("MouseY");

        transform.Rotate(0,Mousex* -1f  * lookSpeed ,0);


    }

    // public void GamePad()
    // {

    // }
}
