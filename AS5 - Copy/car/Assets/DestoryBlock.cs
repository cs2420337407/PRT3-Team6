using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBlock : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        // bullet touch block the block will destory
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
