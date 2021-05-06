using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    // set car wheelmesh wheel max rotate angle,and max torque
    private MeshRenderer[] wheelMesh;
    private WheelCollider[] wheel;
    private float maxAngle;
    private float maxTorque;
    private float h, v;

    void Start()
    {
        // set car max rotate angle 30 ,and max torque 2000
        // link wheelmesh and wheel to the meshRenderer and wheel collider
        maxAngle = 30;
        maxTorque = 2000;
        wheelMesh = transform.GetChild(0).GetComponentsInChildren<MeshRenderer>();
        wheel = transform.GetChild(1).GetComponentsInChildren<WheelCollider>();
    }

    void Update()
    {
        // set move h and v 
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        if (0 == Mathf.Abs(h) && 0 == Mathf.Abs(v)) return;
        Move();

    }

    // Move
    private void Move()
    {
        // only 2 wheel will rotate
        for (int i = 0; i < 2; i++)
        {
            wheel[i].steerAngle = h * maxAngle;
        }

        // set wheel
        foreach (var o in wheel)
        {
            o.motorTorque = maxTorque * v;
            
        }

        // set 4 wheel will rotate when move
        for (int i = 0; i < 4; i++)
        {
            wheelMesh[i].transform.localRotation = Quaternion.Euler(wheel[i].rpm * 360 / 60, wheel[i].steerAngle, 0);

        }
    }

}
