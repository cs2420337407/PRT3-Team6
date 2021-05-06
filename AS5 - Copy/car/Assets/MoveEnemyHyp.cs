using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyHyp : MonoBehaviour
{

    // move speed
    public float speed = 3;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        //Out of range
        if (transform.position.x >= 96.5 || transform.position.x <= 88.5)
        {
            //Reverse
            speed = -speed;

        }

    }

}
