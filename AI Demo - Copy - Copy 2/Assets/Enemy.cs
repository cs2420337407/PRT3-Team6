using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    private CharacterController cc;
    private GameObject p;
    private UnityEngine.AI.NavMeshAgent nma;
    private Animator animator;

    void Start() {
        this.nma = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        this.nma.updatePosition = false;
        this.p = GameObject.FindWithTag("Player");
        this.animator = this.GetComponent<Animator>();
    }

    void Update() {
        this.nma.destination = this.p.transform.position;

        var delta = this.nma.nextPosition - this.transform.position;
        if (delta.sqrMagnitude > this.nma.radius * this.nma.radius) {
            this.nma.nextPosition = this.transform.position + 0.9f * delta;
        }
    }

    void OnAnimatorMove() {
        Vector3 position = this.animator.rootPosition;
        position.y = this.nma.nextPosition.y;
        transform.position = position;
    }

    public void Hit() {
        Debug.Log("Hit!");
    }
}
