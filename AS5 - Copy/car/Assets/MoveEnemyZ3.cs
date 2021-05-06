using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyZ3 : MonoBehaviour
{
    // move speed
    public float speed = 3;
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
        //Out of range
        if (transform.position.z >= 70 || transform.position.z <= 63)
        {
            //Reverse
            speed = -speed;

        }

    }
}
