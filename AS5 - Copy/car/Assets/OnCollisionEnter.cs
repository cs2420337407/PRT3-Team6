using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCollisionEnter : MonoBehaviour
{
 
    // set checkpoint num cpn
    public GameObject CheckPoint;
    public static int cpn;

    void Update()
    {
        // change check point num text
        CheckPoint.GetComponent<Text>().text = "CheckPoint: " + cpn;
    }
}
