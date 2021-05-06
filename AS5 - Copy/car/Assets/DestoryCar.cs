using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestoryCar : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        // xyz car = xyz block destory and restart the game   
        if (col.gameObject.tag == "Block") 
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
