using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    bool isDown = true;
    bool isInside = false;
    public float vel = 50;
    public float timer = 0.0f;
    public GameObject elevator;
    public Vector3 initialState;
    public Vector3 currentState;
    public Vector3 finalState;
    // Start is called before the first frame update
    void Start()
    {
        isDown =true;
        isInside = false;
        //elevator.transform.position = currentState;
        currentState = initialState;
    }

    // Update is called once per frame
    void Update()
    {
        if(isInside)
        {
            elevator.transform.position += Vector3.up * vel * Time.deltaTime;

            if(elevator.transform.position.y >= currentState.y)
            {
                isDown = false;
                Debug.Log("Macaco");
            }
           
        }
         if(elevator.transform.position.y >= finalState.y)
            {
                elevator.transform.position = elevator.transform.position;

                timer += Time.deltaTime;
                if(timer >= 3 )
                {
                   elevator.transform.position -= Vector3.up * vel * Time.deltaTime;
                   timer = 0.0f;
                }
            }
        else
        {
            elevator.transform.position = elevator.transform.position;
        }
    }

    public void OnTriggerEnter(Collider other) 
    {
        switch (other.tag)
        {
            case "Player":

            Debug.Log("Teteu Entrou");
            break;
        }
    }
    public void OnTriggerStay(Collider other) 
    {
         switch (other.tag)
        {
            case "Player":
            isInside = true;
            Debug.Log("subindo");
            break;
        }
    }
    public void OnTriggerExit(Collider other) 
    {
        switch (other.tag)
        {
            case "Player":
            isInside = false;
            Debug.Log("subindo");
            break;
        } 
    }
}
