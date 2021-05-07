using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<NavMeshAgent>().updatePosition = false;
    }

    // Update is called once per frame
    void Update()
    {
    	var agent = this.GetComponent<NavMeshAgent>();
        Vector3 deltaPosition = agent.nextPosition - this.transform.position;
        if (deltaPosition.magnitude > agent.radius) {
        	agent.nextPosition = this.transform.position + 0.5f * deltaPosition;
        }
    }

    void OnAnimatorMove() {
    	Vector3 position = this.GetComponent<Animator>().rootPosition;
    	position.y = this.GetComponent<NavMeshAgent>().nextPosition.y;
    	transform.position = position;
    }
}
