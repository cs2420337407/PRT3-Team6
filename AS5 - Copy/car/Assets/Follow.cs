using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    // follow target
    private Transform targetPos;
    // follow position
    private Vector3 offsetPos;
    // net vect
    private Vector3 tempPos;

    // Start is called before the first frame update
    void Start()
    {
        // Set camera position
        offsetPos = new Vector3(0, 2, -5);
        targetPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // The camera follows the rear of the car
        tempPos = targetPos.position + targetPos.TransformDirection(offsetPos);
        transform.position = Vector3.Lerp(transform.position, tempPos, 
        	Time.fixedDeltaTime * 3);
        transform.LookAt(targetPos);
    }
}
