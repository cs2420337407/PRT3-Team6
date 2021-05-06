using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyY2 : MonoBehaviour
{
    // move speed
    public float speed = 3;
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
        //Out of range
        if (transform.position.z >= -14 || transform.position.z <= -20)
        {
            //Reverse
            speed = -speed;

        }

    }
}
