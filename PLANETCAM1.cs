using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLANETCAM1 : MonoBehaviour
{



    [SerializeField] private Camera cam;

    private Vector3 previousPosition;


    void Update()
    {
        PlanetCam();
    }



    void PlanetCam()
    {


        if (Input.GetMouseButtonDown(1))
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);


        }


        if (Input.GetMouseButton(1))
        {
            Vector3 direction = previousPosition - cam.ScreenToViewportPoint(Input.mousePosition);

            cam.transform.position = new Vector3();

            cam.transform.Rotate(new Vector3(1, 0, 0), direction.y * 5);
            cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 5, Space.World);
            cam.transform.Translate(new Vector3(0, 0, -1800));
        }
    }
}
