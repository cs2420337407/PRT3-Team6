using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouseScale : MonoBehaviour
{

    // set mouse scale min and max also the speed
    public float scaleSpeed = 5.0f;

    private float minScale = 1.0f;

    private float maxScale = 150.0f;

    private float currentScale;

    // Use this for initialization

    void Start()
    {

        //According to whether the current camera is orthogonal or perspective, assign corresponding values

        if (Camera.main.orthographic == true)

        {

            currentScale = Camera.main.orthographicSize;

        }

        else

        {

            currentScale = Camera.main.fieldOfView;

        }

    }

    // Update is called once per frame

    void Update()
    {

        //Get the value of the mouse wheel, forward greater than 0, backward less than 0, and set the zoom range value

        currentScale += Input.GetAxis("Mouse ScrollWheel") * scaleSpeed;

        currentScale = Mathf.Clamp(currentScale, minScale, maxScale);

        //Assign corresponding values according to whether the current camera is orthogonal or perspective, zoom in and out

        if (Camera.main.orthographic == true)

        {

            Camera.main.orthographicSize = currentScale;

        }

        else
        {

            Camera.main.fieldOfView = currentScale;

        }



    }

}
