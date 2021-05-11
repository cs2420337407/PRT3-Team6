using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Animator _animation;
    void Awake()
    {
        _animation = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            //Reset the "Crouch" trigger
            _animation.ResetTrigger("Crouch");
            Debug.Log("Crouch");

            //Send the message to the Animator to activate the trigger parameter named "Jump"
            _animation.SetTrigger("Jump");
        }

        if (Input.GetKey(KeyCode.E))
        {
            //Reset the "Jump" trigger
            _animation.ResetTrigger("Jump");
            Debug.Log("Jump");
            //Send the message to the Animator to activate the trigger parameter named "Crouch"
            _animation.SetTrigger("Crouch");
        }
        if (Input.GetKey(KeyCode.R))
        {
            //Reset the "Jump" trigger
            _animation.ResetTrigger("Jump");

            //Send the message to the Animator to activate the trigger parameter named "Crouch"
            _animation.SetTrigger("Dap");
        }
    }
}
