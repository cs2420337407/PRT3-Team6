using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollictCheckP : MonoBehaviour
{
    // set audio
    public AudioSource cpnSound;
    // set pick up
    private bool picked_up = false;

    // set check point trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !this.picked_up)
        {
            // play sound
            cpnSound.Play();
            // add check point num
            OnCollisionEnter.cpn += 1;
            // des
            Destroy(this.gameObject);

        }

        if (OnCollisionEnter.cpn == 25)
        {
            // stop game if u collect 25 check point
            Time.timeScale = 0;
        }
    }
}
