using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // speed
    public float speed = 100.0f;
    // trun speed
    public float trunSpeed = 10.0f;

    // text
    public Text TimerText;
    // player always playing
    public bool playing;
    // make timer
    private float Timer;

    // Update is called once per frame

    void FixedUpdate()
    {
        //make timer
        Timer += Time.deltaTime;
        int minutes = Mathf.FloorToInt(Timer / 60F);
        int seconds = Mathf.FloorToInt(Timer % 60F);
        int milliseconds = Mathf.FloorToInt((Timer * 100F) % 100F);
        TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + 
                ":" + milliseconds.ToString("00");


        //set rigidbody and transform
        var rigidbody = this.GetComponent<Rigidbody>();
        var transform = this.GetComponent<Transform>();

        // Gas pedal/brakes
        var force = this.speed * Input.GetAxis("Vertical") * Time.fixedDeltaTime;
        Vector3 direction = transform.forward;
        rigidbody.AddForce(force * direction);

        // Turning
        var turnDirection = 1.0f;
        if (Vector3.Dot(transform.forward, rigidbody.velocity) < 0.0f) {
            turnDirection = -1.0f;
        }

        rigidbody.MoveRotation(transform.localRotation * Quaternion.Euler(
            0.0f,
            turnDirection *
                rigidbody.velocity.magnitude * 
                this.trunSpeed * 
                Input.GetAxis("Horizontal") * 
                Time.fixedDeltaTime,
            0.0f));
    }

}
