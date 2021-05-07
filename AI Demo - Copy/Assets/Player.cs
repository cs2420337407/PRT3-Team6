using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;

    private CharacterController cc;

    void Start() {
        this.cc = this.GetComponent<CharacterController>();
    }

    void Update() {
        this.cc.SimpleMove(this.speed * new Vector3(
            Input.GetAxis("Horizontal"),
            0.0f,
            Input.GetAxis("Vertical")));
    }
}
