using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyX2 : MonoBehaviour
{
    // move speed
    public float speed = 3;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        //Out of range
        if (transform.position.x >= 91 || transform.position.x <= 84)
        {
            //Reverse
            speed = -speed;

        }

    }
}
