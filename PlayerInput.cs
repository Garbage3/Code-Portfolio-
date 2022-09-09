using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;

    AudioListener cam1AudioLis;
    AudioListener cam2AudioLis;



    void Start()
    {
        cam1AudioLis = cam1.GetComponent<AudioListener>();
        cam2AudioLis = cam2.GetComponent<AudioListener>();

        cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
    }

    void Update()
    {

        switchCamera();

    }

    public void cameraPositonM()
    {
        cameraChangeCounter();
    }

    void switchCamera()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            cameraChangeCounter();
        }
    }

    void cameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        cameraPositionChange(cameraPositionCounter);

    }

    void cameraPositionChange(int camPosition)
    {
        if (camPosition > 1)
        {
            camPosition = 0;
        }

        PlayerPrefs.SetInt("CameraPosition",camPosition);

        if (camPosition == 0)
        {
            cam1.SetActive(true);
            cam1AudioLis.enabled = true;

            cam2AudioLis.enabled = false;
            cam2.SetActive(false);

        }

        if (camPosition == 1)
        {
            cam2.SetActive(true);
            cam2AudioLis.enabled = true;

            cam1AudioLis.enabled = false;
            cam1.SetActive(false);
        }

    }
}
