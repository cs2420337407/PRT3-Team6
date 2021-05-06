using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyY : MonoBehaviour
{
    // move speed
    public float speed = 3;
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
        //Out of range
        if (transform.position.z >= -25 || transform.position.z <= -32)
        {
            //Reverse
            speed = -speed;

        }

    }
}
