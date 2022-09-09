 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform cameraTransform;


    public float normalSpeed;
    public float fastSpeed;
    public float movementSpeed;
    public float movementTime;
    public float rotationAmount;


    public Vector3 zoomAmount;

    public Vector3 newPosition;
    public Vector3 newZoom;

    public Quaternion newRotation;



   



    void Start()
    {
        newPosition = transform.position;
        newRotation = transform.rotation;
        newZoom = cameraTransform.localPosition;

      

    }

    
    void Update()
    {
            HandleMovementInput();
    }


    void HandleMovementInput()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed = fastSpeed;
        }
        else
        {
            movementSpeed = normalSpeed;
        }


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {

            newPosition += (transform.forward * movementSpeed);


        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {

            newPosition += (transform.forward * -movementSpeed);

        }


        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            newPosition += (transform.right * movementSpeed);

        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            newPosition += (transform.right * -movementSpeed);

        }


        if (Input.GetKey(KeyCode.E))
        {
            newRotation *= Quaternion.Euler(Vector3.up * rotationAmount);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            newRotation *= Quaternion.Euler(Vector3.up * -rotationAmount);
        }


        if (Input.GetKey(KeyCode.R))
        {
            newZoom += zoomAmount;
        }

        if(Input.GetKey(KeyCode.F))
        {
            newZoom -= zoomAmount;
        }





        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementTime);

        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * movementTime);

        cameraTransform.localPosition = Vector3.Lerp(cameraTransform.localPosition, newZoom, Time.deltaTime * movementTime);




    }


      



   



    }
