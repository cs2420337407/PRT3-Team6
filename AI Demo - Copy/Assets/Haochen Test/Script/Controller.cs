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
        if (Input.GetMouseButton(0))
        {
            _animation.SetTrigger("Run");
        }
    }
}
