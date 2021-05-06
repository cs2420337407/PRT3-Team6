using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    //set bullet speed,shoot point , audio
    int bulletSpeed = 100;
    public Rigidbody Bullet;
    public Transform FPoint;
    public AudioSource audioSSource;


    void Start()
    {
        
    }

    void Update()
    {
        // j to shot will clone a bullet and play audio
        if (Input.GetKeyDown(KeyCode.J))
        {
            

            Rigidbody clone;

            clone = (Rigidbody)Instantiate(Bullet, FPoint.position, FPoint.rotation);

            clone.velocity = transform.TransformDirection(Vector3.forward * bulletSpeed);
            
            audioSSource.Play();

        }



    }

}
